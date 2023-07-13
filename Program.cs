using System;
namespace Atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
                    Console.WriteLine("Informar nome:");
                    string var_nome = Console.ReadLine();
                    Console.WriteLine("Informar endereço:");
                    string var_endereco = Console.ReadLine();
                    Console.WriteLine("Pessoa Física (F) ou Jurídica (J)");
                    string var_tipo = Console.ReadLine();

                    if(var_tipo == "f")
                    {
                        //Pessoa Física
                        PessoaFisica pf = new PessoaFisica();
                        pf.nome = var_nome;
                        pf.endereco = var_endereco;
                        Console.WriteLine("Informar o CPF:");
                        pf.cpf = Console.ReadLine();
                        Console.WriteLine("Informe seu RG");
                        pf.rg = Console.ReadLine();
                        Console.WriteLine("Informar valor de compra");
                        val_pag = float.Parse(Console.ReadLine());
                        pf.Pagar_Imposto(val_pag);
                        Console.WriteLine("----------- Pessoa Física -----------");
                        Console.WriteLine("Nome: -------------:"+pf.nome);
                        Console.WriteLine("Endereço ----------:" +pf.endereco);
                        Console.WriteLine("CPF: --------------:"+pf.cpf);
                        Console.WriteLine("RG: ---------------:" +pf.rg);
                        Console.WriteLine("Valor de compra ---:"+ pf.valor.ToString("C"));
                        Console.WriteLine("Imposto -----------:" + pf.valor_imposto.ToString("C"));
                        Console.WriteLine("Total a pagar -----:"+ pf.total.ToString("C"));
                    }
                    if(var_tipo == "j")    
                    {
                        // Pessoa Jurídica
                        PessoaJuridica pj = new PessoaJuridica();
                        pj.nome = var_nome;
                        pj.endereco = var_endereco;
                        Console.WriteLine("Informar o CNPJ:");
                        pj.cnpj = Console.ReadLine();
                        Console.WriteLine("Informe a Inscrição Estadual:");
                        pj.ie = Console.ReadLine();
                        Console.WriteLine("Valor de compra:");
                        val_pag = float.Parse(Console.ReadLine());
                        pj.Pagar_Imposto(val_pag);
                        Console.WriteLine("----------- Pessoa Jurídica -----------");
                        Console.WriteLine("Nome ...........: " + pj.nome);
                        Console.WriteLine("Endereco........: " + pj.endereco);
                        Console.WriteLine("CNPJ ...........: " + pj.cnpj);
                        Console.WriteLine("IE .............: " + pj.ie);
                        Console.WriteLine("Valor de compra.: " + pj.valor.ToString("C"));
                        Console.WriteLine("Imposto.........: " + pj.valor_imposto);
                        Console.WriteLine("Total a pagar ..:" + pj.total.ToString("C"));
                         
                    }
                    

        }
    }


}
