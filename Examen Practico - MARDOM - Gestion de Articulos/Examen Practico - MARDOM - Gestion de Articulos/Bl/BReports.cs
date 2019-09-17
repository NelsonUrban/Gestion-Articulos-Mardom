using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Repository;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using Microsoft.Reporting.WebForms;
using System.Web.UI.WebControls;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Bl
{
    public class BReports
    {
        private Rreports _reports;
        public BReports()
        {
            this._reports = new Rreports(new Gestion_Articulos_MardomEntities1());
        }
        public IEnumerable<Sp_Report_List_Articulos_Result> getListArticulos()
        {

            return _reports.getListArticulos().ToList();
        }
        public ReportViewer GetReport(string ruta)
        {
            //ReportViewer
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            reportViewer.LocalReport.ReportPath = ruta;

            //ReportViewer DataSource
            var ListArticulos = _reports.getListArticulos().ToList();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsListadodeArticulos", ListArticulos));

            //ReportViewer Parameters
            //ReportParameter p1 = new ReportParameter("hideCusPhone", HideCusPhone.ToString());
            //[] reportParameters = new ReportParameter[] { p1 };
           // reportViewer.LocalReport.SetParameters(reportParameters);

            //Return ReportViewr for MVC
            return reportViewer;
        }


    }
}