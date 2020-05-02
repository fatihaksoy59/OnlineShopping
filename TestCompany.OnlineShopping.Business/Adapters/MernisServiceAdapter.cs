using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Business.Abstract;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool IsRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(customer.NationalIdentityNumber),
                    customer.FirstName.ToUpper(),
                    customer.LastName.ToUpper(),
                    customer.BirthDate.Year
                    ))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
