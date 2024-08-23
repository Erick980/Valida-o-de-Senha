using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        
        // Sofware de validação de senha
        Console.WriteLine("Digite a senha: ");
        string senha = Console.ReadLine();
        Console.WriteLine("Confirme a senha novamente: ");
        string senha2 = Console.ReadLine();
        
        ValidarSenha(senha, senha2);
        
        
    }
    static void ValidarSenha(string senha, string senha2) {


        // faz a validação
        bool tamanhoValido = senha.Length >= 8;
        bool contemNumero = senha.Any(char.IsDigit);
        bool contemMaiuscula = senha.Any(char.IsUpper);
        
        // faz a validação da confirmação
        bool tamanhoValido2 = senha2.Length >= 8;
        bool contemNumero2 = senha2.Any(char.IsDigit);
        bool contemMaiuscula2 = senha2.Any(char.IsUpper);
        
        if (senha == senha2) {
        // testa se todos foram posa2itivos
            if (tamanhoValido && contemMaiuscula && contemNumero) {
                    Console.WriteLine("Senha Valida!");
                    
            } else {
                    Console.WriteLine("Senha Invalida!");
            }
        } else { 
            Console.WriteLine("Digite as senhas iguais"); 
            
        }

    }
 
}

