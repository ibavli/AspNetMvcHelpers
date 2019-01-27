using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebHelperWebImage.Controllers
{
    public class HomeController : Controller
    {
        private string resimYolu
        {
            get
            {
                return Server.MapPath("~/Fotograflar/windows_xp_bliss-wide.jpg");
            }
        }

        private string resimYolu2
        {
            get
            {
                return Server.MapPath("~/Fotograflar/visualstudiologo.jpg");
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        public void ResimGoruntule()
        {
            WebImage resim = new WebImage(resimYolu);
            resim.Write();
        }

        public void ResmiSagaDondur()
        {
            WebImage resim = new WebImage(resimYolu);
            resim.RotateRight();
            resim.Write();
        }

        public void ResmiSolaDondur()
        {
            WebImage resim = new WebImage(resimYolu);
            resim.RotateLeft();
            resim.Write();
        }

        public void ResmiYatayCevir()
        {
            WebImage resim = new WebImage(resimYolu);
            resim.FlipHorizontal();
            resim.Write();
        }

        public void ResmiDikeyCevir()
        {
            WebImage resim = new WebImage(resimYolu);
            resim.FlipVertical();
            resim.Write();
        }

        public void ResmiYenidenBoyutlandır()
        {
            /*
             4 tane parametre alır. 2'si zorunlu 2'si opsiyonel.
             width : Yeni oluşacak resmin genişliği
             height : Yeni oluşacak resmin yüksekliği
             preserveAspectRatio : Resmin en boy oranının korunup korunmayacağını belirler. True false değer alır.
             preventEnLarge : Yeni oluşacak resmin boyutlarının orjinal resimden büyük olup olmamasının kontrol edildiği parametredir. Eğer yeni resmin boyutlarının eskiden büyük olması istenmiyorsa true, isteniyorsa false değer alır.
            */

            WebImage resim = new WebImage(resimYolu);
            resim.Resize(100, 100, preserveAspectRatio: true);
            resim.Write();
        }

        public void ResmiKesme()
        {
            /*
            4 tane opsiyonel parametre alır.
            
            top: Kesim işleminin orjinal resmin üstünden (en üst 0. piksel) başlayarak kaç piksel aşağısından başlanacağını tanımlar.
            left: Kesim işleminin orjinal resmin solundan (en sol 0. piksel) başlayarak kaç piksel sağından başlanacağını tanımlar.
            right: Kesim işleminin orjinal resmin sağından (en sağ 0. piksel) başlayarak kaç piksel solundan başlanacağını tanımlar.
            bottom: Kesim işleminin orjinal resmin altından (en alt 0. piksel) başlayarak kaç piksel üstünden başlanacağını tanımlar.
            */
            WebImage resim = new WebImage(resimYolu);
            resim.Crop(top: 180, left: 1, bottom: 60, right:10);
            resim.Write();
        }

        public void ResminUzerineYaziEkleme()
        {
            /*
            AddTextWatermark : 1 zorunlu, 8 opsiyonel parametre içerir.

            text : Resmin üzerine eklenecek yazı.
            fontColor : Yazı rengi.
            fontSize : Yazı büyüklüğü
            fontStyle : Yazının nasıl olacağıdır (düz, eğik, kalın..) Varsayılan Regular'dır.
            fontFamily : Yazı fontunun ne olacağıdır. Varsayılan Microsoft Sans Serif'tir.
            horizontalAlign : Yazının yatay hizalamasının nasıl olacağıdır. Varsayılan Right'tır.
            verticalAlign : Yazının dikey hizalamasının nasıl olacağıdır. Varsayılan Bottom'dır.
            opacity : Yazının saydamlığının tanımlandığı parametredir. Varsayılan değeri 100'dür. 0'dan 100'e doğru saydamlığı azalır.
            padding : Yazı ile resmin kenarı arasındaki boşluğun taımlandığı parametredir. Varsayılan değeri 5'tir.
            */
            WebImage resim = new WebImage(resimYolu);
            resim.AddTextWatermark("WebImage ile Test yazısı", fontColor: "Red", fontSize: 20, horizontalAlign: "Center", verticalAlign: "Middle");
            resim.Write();
        }

        public void ResminUzerineResimEkleme()
        {
            /*
            AddImageWatermark : 1 zorunlu, 6 opsiyonel parametre içerir.

            watermarkImage : Resmin üzerine eklenecek resmin yolunun tanımlandığı parametredir.
            width : Filigran resmin genişliği.
            height : Filigran resmin yüksekliği.
            horizontalAlign : Filigran resmin yatay hizalamasının nasıl olacağıdır. Varsayılan Right'tır.
            verticalAlign : Filigran resmin dikey hizalamasının nasıl olacağıdır. Varsayılan Bottom'dır.
            opacity : Filigran resmin saydamlığının tanımlandığı parametredir. Varsayılan değeri 100'dür. 0'dan 100'e doğru saydamlığı azalır.
            padding : Filigran resmin ile resmin kenarı arasındaki boşluğun taımlandığı parametredir. Varsayılan değeri 5'tir.
            */
            WebImage resim = new WebImage(resimYolu);
            resim.AddImageWatermark(resimYolu2, width: 100, height: 100, horizontalAlign: "Center", verticalAlign: "Middle", opacity: 100);
            resim.Write();
        }
    }
}