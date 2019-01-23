using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedHelper.Models
{
    public class Personel
    {
        private readonly List<Cinsiyet> _cinsiyetler = new List<Cinsiyet>
        {
            new Cinsiyet { Id = 1, Ad = "Erkek"},
            new Cinsiyet { Id = 2, Ad = "Kadın"}
        };

        private readonly List<MedeniDurum> _medeniDurumlar = new List<MedeniDurum>
        {
            new MedeniDurum { Id = 1, Ad = "Bekar"},
            new MedeniDurum { Id = 2, Ad = "Evli"},
            new MedeniDurum { Id = 2, Ad = "Dul"}
        };

        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Adı")]
        public string Ad { get; set; }

        [Required]
        [DisplayName("Soyadı")]
        public string Soyad { get; set; }

        [Required]
        [DisplayName("Doğum Tarihi")]
        public DateTime DogumTarih { get; set; }

        [Required]
        [DisplayName("TC Kimlik No")]
        public string TCKimlikNo { get; set; }

        [Required]
        [DisplayName("Cinsiyet")]
        public string Cinsiyet { get; set; }

        [Required]
        [DisplayName("Medeni Durum")]
        public string MedeniDurum { get; set; }

        [Required]
        [DisplayName("Çocuğa var mı")]
        public bool CocukVarMi { get; set; }

        [Required]
        [DisplayName("Sakatlık Durumu")]
        public int SakatlikDurumu { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Sifre { get; set; }

        [DisplayName("Diğer Bilgiler")]
        public string DigerBilgiler { get; set; }

        public IEnumerable<SelectListItem> Cinsiyetler
        {
            get
            {
                return new SelectList(_cinsiyetler, "Id", "Ad");
            }
        }

        public IEnumerable<SelectListItem> MedeniDurumlar
        {
            get
            {
                return new SelectList(_medeniDurumlar, "Id", "Ad");
            }
        }
    }
}