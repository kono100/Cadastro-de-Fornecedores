using CadastroDeFornecedores.Data;
using CadastroDeFornecedores.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace CadastroDeFornecedores.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Criar Fornecedores se estiver vazia
                if (!context.Fornecedor.Any())
                {
                    context.Fornecedor.AddRange(new List<FornecedorModel>()
                    {

                        new FornecedorModel()
                        {
                        CNPJ = "40.432.544/0001-47",
                        RazaoSocial = "CLARO S.A.",
                        NomeFantasia = "CLARO", 
                        Email = "atendimento.fiscalizacoes@claro.com.br",
                        Telefone = "(11) 4313-4620",
                        NomePessoaContato = "João da Infraestrutura",
                        logradouro = "RUA HENRI DUNANT",
                        Numero = "780",
                        Complemento = "TORRE A E TORRE B",
                        Bairro = "SANTO AMARO",
                        Municipio = "São paulo",
                        CEP = "04709-110",
                        Estado = "SP"
                        },




                        new FornecedorModel()
                        {
                        CNPJ = "33.014.556/0001-96",
                        RazaoSocial = "LOJAS AMERICANAS S.A.",
                        NomeFantasia = "Lojas Americanas",
                        Email = "sede@lasa.com.br",
                        Telefone = "(21) 2206-6708",
                        NomePessoaContato = "Fabio da T.I.",
                        logradouro = "AVENIDA SACADURA CABRAL",
                        Numero = "102",
                        Complemento = "",
                        Bairro = "SAUDE",
                        Municipio = "Rio de Janeiro",
                        CEP = "20081-902",
                        Estado = "RJ"
                        },



                        new FornecedorModel()
                        {
                        CNPJ = "56.024.581/0001-56",
                        RazaoSocial = "MUNICIPIO DE RIBEIRAO PRETO",
                        NomeFantasia = "Prefeitura de Ribeirão Preto",
                        Email = "gabinete@governo.pmrp.com.br",
                        Telefone = "(16) 3977-9000",
                        NomePessoaContato = "Prefeito de Ribeirão",
                        logradouro = "RUA AMERICO BRASILIENSE",
                        Numero = "426",
                        Complemento = "",
                        Bairro = "CENTRO",
                        Municipio = "Ribeirão preto",
                        CEP = "14015-050",
                        Estado = "SP"
                        },



                        new FornecedorModel()
                        {
                        CNPJ = "23.412.247/0001-10",
                        RazaoSocial = "AMAZON AWS SERVICOS BRASIL",
                        NomeFantasia = "AWS",
                        Email = "amzbr-tax-compliance@amazon.com",
                        Telefone = "(11) 2827-4500",
                        NomePessoaContato = "Fornecedor de Infraestrutura",
                        logradouro = "RUA PRESIDENTE JUSCELINO KUBITSCHEK",
                        Numero = "2041",
                        Complemento = "ANDAR 18 E 19 TORRE E",
                        Bairro = "VILA NOVA CONCEICAO",
                        Municipio = "São Paulo",
                        CEP = "04543-000",
                        Estado = "SP"
                        },



                        //new FornecedorModel()
                        //{
                        //CNPJ = "t",
                        //RazaoSocial = "t",
                        //NomeFantasia = "t",
                        //Email = "t",
                        //Telefone = "t",
                        //NomePessoaContato = "t",
                        //logradouro = "t",
                        //Numero = "t",
                        //Complemento = "t",
                        //Bairro = "t",
                        //Municipio = "t",
                        //CEP = "t"
                        //Estado = "SP"
                        //},




                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
