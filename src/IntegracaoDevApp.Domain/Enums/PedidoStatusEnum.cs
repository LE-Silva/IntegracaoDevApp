using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Domain.Enums
{
    public enum PedidoStatusEnum
    {
        Aberto = 0,
        Fechado = 1
    }
    public static class PedidoStatusEnumExtensions
    {
        private const string ABERTO = "A";
        private const string FECHADO = "F";

        public static string ToDataValue(this PedidoStatusEnum value)
        {
            return value == PedidoStatusEnum.Fechado ? FECHADO : ABERTO;
        }

        public static PedidoStatusEnum ToPedidoStatusEnum(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return PedidoStatusEnum.Aberto;
            if (value == FECHADO)
                return PedidoStatusEnum.Fechado;
            else
                return PedidoStatusEnum.Aberto;
        }
    }
}
