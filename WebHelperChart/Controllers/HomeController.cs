using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebHelperChart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChartTekVeri()
        {
            var grafik = new Chart(width: 400, height: 400); //Genişlik ve yükseklik tanımlandı.

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları"); //Başlık tanımladık

            grafik.AddLegend(title: "Veriler"); //Grafiğin verilerinin açıklamalarının bulunduğu bölümün başlığını tanımladık.

            //Verilerimizi tanımladık.
            grafik.AddSeries(
                name: "Ortalamalar",
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }

        public ActionResult ChartIkiVeri()
        {
            var grafik = new Chart(width: 400, height: 400); //Genişlik ve yükseklik tanımlandı.

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları ve dersin saatleri"); //Başlık tanımladık

            grafik.AddLegend(title: "Veriler"); //Grafiğin verilerinin açıklamalarının bulunduğu bölümün başlığını tanımladık.

            //Verilerimizi tanımladık.
            grafik.AddSeries(
                name: "Ortalamalar",
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );
            
            grafik.AddSeries(
                name: "Ders saatleri",
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 6, 4, 4 }
                );

            return View(grafik);
        }


        public ActionResult ChartPointTema()
        {
            var grafik = new Chart(width: 400, height: 400); 

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları"); 

            grafik.AddLegend(title: "Veriler"); 

            
            grafik.AddSeries(
                name: "Ortalamalar", chartType: "Point", //Point tema ekledik
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }

        public ActionResult ChartBubbleTema()
        {
            var grafik = new Chart(width: 400, height: 400);

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları");

            grafik.AddLegend(title: "Veriler");


            grafik.AddSeries(
                name: "Ortalamalar", chartType: "Bubble", //Bubble tema ekledik
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }


        public ActionResult ChartLineTema()
        {
            var grafik = new Chart(width: 400, height: 400);

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları");

            grafik.AddLegend(title: "Veriler");


            grafik.AddSeries(
                name: "Ortalamalar", chartType: "Line", //Line tema ekledik
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }

        public ActionResult ChartSplineTema()
        {
            var grafik = new Chart(width: 400, height: 400);

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları");

            grafik.AddLegend(title: "Veriler");


            grafik.AddSeries(
                name: "Ortalamalar", chartType: "Spline", //Spline tema ekledik
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }

        public ActionResult ChartBarTema()
        {
            var grafik = new Chart(width: 400, height: 400);

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları");

            grafik.AddLegend(title: "Veriler");


            grafik.AddSeries(
                name: "Ortalamalar", chartType: "Bar", //Bar tema ekledik
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }

        public ActionResult ChartAreaTema()
        {
            var grafik = new Chart(width: 400, height: 400);

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları");

            grafik.AddLegend(title: "Veriler");


            grafik.AddSeries(
                name: "Ortalamalar", chartType: "Area", //Area tema ekledik
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }

        public ActionResult ChartSplineAreaTema()
        {
            var grafik = new Chart(width: 400, height: 400);

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları");

            grafik.AddLegend(title: "Veriler");


            grafik.AddSeries(
                name: "Ortalamalar", chartType: "SplineArea", //SplineArea tema ekledik
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }

        public ActionResult ChartPieTema()
        {
            var grafik = new Chart(width: 400, height: 400);

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları");

            grafik.AddLegend(title: "Veriler");


            grafik.AddSeries(
                name: "Ortalamalar", chartType: "Pie", //Pie tema ekledik
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }

        public ActionResult ChartDoughnutTema()
        {
            var grafik = new Chart(width: 400, height: 400);

            grafik.AddTitle(text: "1. sınıf 1. dönem not ortalamaları");

            grafik.AddLegend(title: "Veriler");


            grafik.AddSeries(
                name: "Ortalamalar", chartType: "Doughnut", //Doughnut tema ekledik
                xValue: new[] { "Matematik", "Sosyal", "Türkçe" },
                yValues: new[] { 80, 30, 55 }
                );


            return View(grafik);
        }
    }
}