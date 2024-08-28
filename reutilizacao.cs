using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Sofware de validação de senha
        Console.WriteLine("Digite uma senha:");
        String senha = ValidarSenha(Console.ReadLine());

        Console.Write("\nConfirme a senha:");
        string confirmarSenha = ValidarSenha(Console.ReadLine());

        bool igual = ComparaTexto(senha, confirmarSenha);

        if (igual)
        {
            Console.WriteLine("\nArmazenando dados!");
        }
        else
        {
            Console.WriteLine("\nRefaca o processo!");
        }
    }
    private static string ValidarSenha(string texto)
    {
        if (texto.Length < 8)
        {
            Console.WriteLine("Tamanho Invalido!");
        }
        if (!texto.Any(char.IsDigit))
        {
            Console.WriteLine("Nao possui numeros");
        }
        if (!texto.Any(char.IsUpper))
        {
            Console.WriteLine("Nao possui letra maiuscula!");
        }

        if (texto == regex.test('a@4DFFd$fd'))
        {
            Console.WriteLine("Nao possui caracteres especiais!");
        }
        return texto;
    }
    private static bool ComparaTexto(string senha, string confirmarSenha)
    {
        if (senha == confirmarSenha)
        {
            Console.WriteLine("\nSenhas conferem");
            return true;
        }
        else
        {
            Console.WriteLine("\nSenhas nao conferem");
            return false;
        }

    }
}


// Criar validação de carcter especial
// criar flag para validação de texto iguais