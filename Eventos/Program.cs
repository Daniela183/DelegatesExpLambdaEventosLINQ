//aula 186
Console.WriteLine("Eventos\n");

Console.WriteLine("Usando o evento OnCriarPedido");

var pedido = new Pedido();

//inscrever os assinantes em um evento
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();

Console.ReadKey();

delegate void PedidoEventHandler();
class Pedido
{
    //criar o evento associado ao delegate
    public event PedidoEventHandler? OnCriarPedido;
    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado!");

        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

class Email
{
    public static void Enviar()
    {
        Console.WriteLine("\nEnviando um email");
    }
}

class SMS
{
    public static void Enviar()
    {
        Console.WriteLine("\nEnviando um SMS");
    }
}