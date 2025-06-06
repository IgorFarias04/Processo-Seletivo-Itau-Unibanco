using System.Collections.Generic;
using System;

namespace ControleInvestimentos.Servicos
{
    public class CalculadoraPrecoMedio
    {
        public static decimal CalcularPrecoMedio(List<(int quantidade, decimal precoUnitario)> compras)
        {
            if (compras == null || compras.Count == 0)
                throw new ArgumentException("A lista de compras está vazia.");

            decimal totalInvestido = 0;
            int totalQuantidade = 0;

            foreach (var compra in compras)
            {
                if (compra.quantidade <= 0 || compra.precoUnitario < 0)
                    throw new ArgumentException("Compra inválida: quantidade deve ser > 0 e preço >= 0.");

                totalInvestido += compra.quantidade * compra.precoUnitario;
                totalQuantidade += compra.quantidade;
            }

            if (totalQuantidade == 0)
                throw new DivideByZeroException("Quantidade total é zero. Não é possível calcular.");

            return totalInvestido / totalQuantidade;
        }
    }
}

