using Microsoft.Reporting.WinForms;
using Repositorio.Entidades.Entidades.Sial;
using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sial.View.Relatorio
{
    public partial class frmRelatorio : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmRelatorio));
        private readonly ISialSession SialSession;
        private Edital Edital;

        public frmRelatorio(int idEdital, Enumeradores.Relatorio relatorio )
        {
            InitializeComponent();

            SialSession = new SialSession();

            Edital = SialSession.Edital.BuscarPorId(idEdital);

            switch (relatorio)
            {
                case Enumeradores.Relatorio.Capa:
                    GerarRelCapa();
                    break;
                case Enumeradores.Relatorio.Etiqueta:
                    GerarRelEtiqueta();
                    break;
                case Enumeradores.Relatorio.Participantes:
                    GerarRelParticipantes();
                    break;
                default:
                    break;
            }

        }

        public frmRelatorio(DateTime dataDe, DateTime dataAte, int destino, Enumeradores.Relatorio relatorio)
        {
            InitializeComponent();

            SialSession = new SialSession();

            switch (relatorio)
            {
                case Enumeradores.Relatorio.Licitacao:
                    GerarRelLicitacao(dataDe, dataAte, destino);
                    break;
                default:
                    break;
            }

        }

        private void GerarRelCapa()
        {
            rptViewer.LocalReport.ReportPath = @"Reports\Capa.rdlc";

            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("LoteDs", Edital.Lote));
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("AcompanhamentoDs", Edital.Acompanhamento));

            rptViewer.LocalReport.SetParameters(new ReportParameter("IdEdital", Edital.IdEdital.ToString()));
            rptViewer.LocalReport.SetParameters(new ReportParameter("NumEdital", Edital.NumeroEdital));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Apelido", Edital.Apelido));
            rptViewer.LocalReport.SetParameters(new ReportParameter("DataEnt", Edital.DataHoraEntrega.ToString("dd/MM/yyyy")));
            rptViewer.LocalReport.SetParameters(new ReportParameter("HoraEnt", Edital.DataHoraEntrega.ToString("HH:mm")));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Objeto", Edital.Objeto));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Contratante", Edital.Orgao != null ? Edital.Orgao.Nome : ""));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Observacao", Edital.Observacao));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Responsavel", Edital.Responsavel != null ? Edital.Responsavel.Nome : ""));
            rptViewer.RefreshReport();

        }
        private void GerarRelEtiqueta()
        {
            rptViewer.LocalReport.ReportPath = @"Reports\Etiqueta.rdlc";

            rptViewer.LocalReport.SetParameters(new ReportParameter("IdEdital", Edital.IdEdital.ToString()));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Ano", Edital.DataHoraEntrega.ToString("yyyy")));
            rptViewer.LocalReport.SetParameters(new ReportParameter("NumEdital", Edital.NumeroEdital));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Apelido", Edital.Apelido));
            rptViewer.LocalReport.SetParameters(new ReportParameter("DataEnt", Edital.DataHoraEntrega.ToString("dd/MM/yyyy")));
            rptViewer.LocalReport.SetParameters(new ReportParameter("HoraEnt", Edital.DataHoraEntrega.ToString("HH:mm:ss")));
            rptViewer.RefreshReport();
        }
        private void GerarRelParticipantes()
        {
            rptViewer.LocalReport.ReportPath = @"Reports\EmpParticipantes.rdlc";

            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("LoteDs", Edital.Lote));
            rptViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);
            rptViewer.LocalReport.SetParameters(new ReportParameter("IdEdital", Edital.IdEdital.ToString()));
            rptViewer.LocalReport.SetParameters(new ReportParameter("NumEdital", Edital.NumeroEdital));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Apelido", Edital.Apelido));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Objeto", Edital.Objeto));
            rptViewer.LocalReport.SetParameters(new ReportParameter("Contratante", Edital.Orgao.Nome));
            rptViewer.RefreshReport();
        }
        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("dsEmpresa", SialSession.Edital.BuscarRelLicitacoes(Edital.IdEdital)));
        }
        private void GerarRelLicitacao(DateTime dataDe, DateTime dataAte, int destino)
        {
            rptViewer.LocalReport.ReportPath = @"Reports\Licitacoes.rdlc";

            var listaLicitacoes = SialSession.Edital.BuscarRelLicitacoes(dataDe, dataAte, destino);

            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("dsLicitacoes", listaLicitacoes));

            List<ReportParameter> parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("DataDe", dataDe.ToString("dd/MM/yyyy")));
            parametros.Add(new ReportParameter("DataAte", dataAte.ToString("dd/MM/yyyy")));
            rptViewer.LocalReport.SetParameters(parametros);

            rptViewer.RefreshReport();
        }
    }
}
