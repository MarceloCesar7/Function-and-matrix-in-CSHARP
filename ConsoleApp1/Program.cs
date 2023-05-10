const int L = 3;
const int C = 3;

void leitura ( int[,] matriz)
{
    for (int i = 0; i < L; i++)
        for (int j = 0; j < C; j++)
            matriz[i, j] = int.Parse(Console.ReadLine());

}
void mostra ( int[,] matriz)
{
    for (int i = 0; i < L; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < C; j++)
            Console.Write(matriz[i, j]+ " ");
    }
}
int soma_diagonal ( int[,] matriz)
{
    int soma = 0;
    for (int i = 0; i < C; i++)
        for (int j = 0; j < L; j++)
            if (i == j)
                soma = soma + matriz[i, j];
    return soma;
    
}
int diagonal_secundaria ( int[,] matriz)
{
    int soma = 0;
    for (int k = 0; k < C; k++)
        for ( int l = 0; l < L; l++)
                if (k+l== L - 1)
                soma = soma +matriz[k, l];
    return soma;
}
int somamatriz ( int[,] matriz)
{
    int soma = 0;
for ( int i =0; i<L;i++)
        for (int j =0; j<L;j++)
            soma = soma +matriz[i, j];
    return soma;

}
int subtracao ( int[,] m, int[,]m2)
{
    int subtracao=0;
    for (int i = 0; i < L; i++)
        for (int j = 0; j < C; j++)
            subtracao = m[i,j] - m2[i, j];
    return subtracao;
}
int somaduas ( int[,] m, int[,] m2)
{
    int soma = 0;
    for (int i = 0; i < L; i++)
        for (int j = 0; j < C; j++)
            soma = m[i, j] + m2[i, j];
    return soma;

}




int[,] m = new int[L, C];
int[,] m2 = new int[L, C];
Console.WriteLine("Digite a primeira matriz");
leitura(m);
Console.WriteLine("Mostrando a primeira matriz");
mostra(m);
Console.WriteLine("Digite a segunda matriz");
leitura(m2);
Console.WriteLine("Mostrando a segunda matriz");
Console.WriteLine();
mostra(m2);
Console.WriteLine();
Console.WriteLine("soma da diagonal principal");
Console.WriteLine(soma_diagonal(m));
Console.WriteLine();
Console.WriteLine("soma da Diagonal secundaria");
Console.WriteLine(diagonal_secundaria(m));
Console.WriteLine();
Console.WriteLine("Soma da matriz");
Console.WriteLine(somamatriz(m));
Console.WriteLine("Subtração das duas matrizes");
Console.WriteLine(subtracao(m,m2));
Console.WriteLine("soma das duas matrizes");
Console.WriteLine(somaduas(m,m2));