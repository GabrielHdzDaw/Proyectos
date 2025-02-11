using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListaCompra
{
    internal class Compra
    {
        Producto producto;
        int urgencia;
        bool adquirido;
        DateTime fecha;

        public Compra(Producto producto, int urgencia, bool adquirido, DateTime fecha)
        {
            this.producto = producto;
            this.urgencia = urgencia > 0 && urgencia < 10 ? urgencia : 0;
            this.adquirido = false;
            this.fecha = DateTime.Now;
        }

        public Producto GetProducto()
        {
            return producto;
        }

        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }

        public int GetUrgencia()
        {
            return urgencia;
        }

        public void SetUrgencia(int urgencia)
        {
            this.urgencia = urgencia;
        }

        public bool GetAdquirido()
        {
            return adquirido;
        }

        public void SetAdquirido(bool adquirido)
        {
            this.adquirido = adquirido;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }

        public void SetFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }
        public override string ToString()
        {
            return $"Producto: {producto}, Urgencia: {urgencia}, Adquirido: {adquirido}, Fecha: {fecha}";
        }
    }
}
