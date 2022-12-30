using CarPark.Models.ViewModels.Personels;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Business.tcDogrulama
{
    public class tcDog
    {
        public bool dogrulama(PersonelProfileInfo personelinfo)
        {
            var client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(personelinfo.tcNo), personelinfo.Name.ToUpper(), personelinfo.Surname.ToUpper(), personelinfo.dogumYili);
            var a = result.Result.Body.TCKimlikNoDogrulaResult;
            return a;

        }
    }
}
