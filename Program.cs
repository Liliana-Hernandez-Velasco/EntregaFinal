using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace EntregaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola René!");
        }
    }
}
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NombreUsuario { get; set; }
    public double Contraseña { get; set; }
    public double Mail { get; set; } 
}
public class Producto
{
    public long Id { get; set; }
    public string Descripción { get; set; }
    public double Costo { get; set; }
    public double PrecioVenta { get; set; }
    public int Stock { get; set; }
    public long IdUsuario { get; set; } 
}
public class ProductoVendido
{
    public long Id { get; set; }
    public long IdProducto { get; set; }
    public int Stock { get; set; }
    public long IdVenta { get; set; }
    public long IdUsuario { get; set; }

}
public class Venta
{
    public long Id { get; set; }
    public string Comentarios { get; set; }
    public long IdUsuario { get; set; }
}
}
private static List<Usuario> DevolverUsuarios();
{
    var listaUsuarios = new List<Usuario>();
    string connectionString = "Server=HERNANDL3;Database=SistemaGestion;Trusted_Connection=True";
    var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail, FROM Usuario";
    using (SqlConnection conect = new SqlConnection (connectionString))
    {
        using (SqlCommand comando = new SqlCommand(query, connectionString))
        {
            connect.Open();
            using (SqlDataReader dr = comando.ExecuteReader())
            {
                if (dr.HasRows()) 
                { 
                while (dr.Read()) 
                    {
                        var usuario= new Usuario();
                        usuario.Id= Convert.ToInt32(dr["ID"]);
                        usuario.Nombre= dr["Nombre"].ToString();
                        usuario.Apellido = dr["Apellido"].ToString();
                        usuario.NombreUsuario= dr["NombreUsuario"].ToString();
                        usuario.Contraseña = dr["Contraseña"].ToString();
                        usuario.Mail = dr["Mail"].ToString();
                        listaUsuarios.Add(usuario);
                        List<Usuario> listaUsuarios = DevolverUsuarios();
                    }
            }
        }
    }
}
    private static List<Producto> DevolverProductos();
    {
        var listaProductos = new List<Producto>();
        string connectionString = "Server=HERNANDL3;Database=SistemaGestion;Trusted_Connection=True";
        var query = "SELECT Id, Descripción, Costo, PrecioVenta, Stock, IdUsuario, FROM Producto";
        using (SqlConnection conect = new SqlConnection(connectionString))
        {
            using (SqlCommand comando = new SqlCommand(query, connectionString))
            {
                connect.Open();
                using (SqlDataReader dr = comando.ExecuteReader())
                {
                    if (dr.HasRows())
                    {
                        while (dr.Read())
                        {
                            var producto = new Producto();
                            producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                            producto.Descripción = dr["Descripción"].ToString();
                            producto.Costo = dr["Costo"].ToString();
                            producto.PrecioVenta = dr["PrecioVenta"].ToString();
                            producto.Stock = dr["Stock"].ToString();
                            listaProductos.Add(producto);
                            List<Producto> listaProductos = DevolverProductos();
                        }
                    }
                }
            }
        }
        private static List<ProductoVendido> DevolverProductosVendidos();
        {
            var listaProductosVendidos = new List<ProductoVendido>();
            string connectionString = "Server=HERNANDL3;Database=SistemaGestion;Trusted_Connection=True";
            var query = "SELECT IdUsuario, IdProducto, Stock, IdVenta, FROM ProductoVendido";
            using (SqlConnection conect = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, connectionString))
                {
                    connect.Open();
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows())
                        {
                            while (dr.Read())
                            {
                                var productoVendido = new ProductoVendido();
                                productoVendido.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                productoVendido.IdProducto = dr["Descripción"].ToString();
                                productoVendido.Stock = dr["Costo"].ToString();
                                productoVendido.IdVenta = dr["PrecioVenta"].ToString();
                                listaProductosVendidos.Add(DevolverProductosVendidos);
                                List<ProductoVendido> listaProductosVendidos = DevolverProductosVendidos();
                            }
                        }
                    }
                }
            }
            private static List<Venta> DevolverVentas();
            {
                var listaVentas = new List<Venta>();
                string connectionString = "Server=HERNANDL3;Database=SistemaGestion;Trusted_Connection=True";
                var query = "SELECT IdUsuario, Comentarios, IdUsuario, FROM Venta";
                using (SqlConnection conect = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand(query, connectionString))
                    {
                        connect.Open();
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows())
                            {
                                while (dr.Read())
                                {
                                    var Venta = new Venta();
                                    Venta.IdUsuario = Convert.ToInt32(dr["ID"]);
                                   Venta.Comentarios = dr["Comentarios"].ToString();
                                    Venta.ID = dr["ID"].ToString();
                                    listaVentas.Add(DevolverVentas);
                                    List<Venta> listaVentas = DevolverVentas();
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Por favor, ingrese su usuario y contraseña");
                string Contraseña = Console.ReadLine();
                string NombreUsuario = Console.ReadLine();
                int intentos = 5;

                for (int i = 0; i < intentos; i++)
                {
                    if (Contraseña == Contraseña) if (NombreUsuario== NombreUsuario)
                    {
                        Console.WriteLine("IdUsuario");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("contraseña incorrecta, vuleve a intentarlo");
                        contraseña = Console.ReadLine();
                    }
                }