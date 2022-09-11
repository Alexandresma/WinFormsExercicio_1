using System;

public class ListaProduto
{
    private string produto;
    private int quantidade;
    private double precoUnitario;
    private double subTotal;

    public ListaProduto()
	{

	}

    public ListaProduto(string produto, int quantidade, double precoUnitario, double subTotal)
    {
        this.produto = produto;
        this.quantidade = quantidade;
        this.precoUnitario = precoUnitario;
        this.subTotal = subTotal;
    }

    public string Produto { get => produto; set => produto = value; }
    public int Quantidade { get => quantidade; set => quantidade = value; }
    public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }
    public double SubTotal { get => subTotal; set => subTotal = value; }


}
