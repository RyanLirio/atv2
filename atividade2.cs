using System.Collections;

//Utilizando a Lista Simples
ArrayList arrayList = new();
arrayListAdd(5);
arrayList.Add("Ryan");
//
//
arrayList.AddRange(new[] {1,2,3}); 
//O método .Add() insere o valor ao finaldo vetor
//
arrList.Insert(1,15);
//Já o metodo insert, me permite incluir o valor desejado na posição especificada no primeiro parâmentro;

//lendo valores da lista
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

//percorrendo a lista com o foreach
foreach(objeto obj in arrList)
{
    Console.Write(obj);
}

int tamanho = arrList .Count;

int capacidade = arrList.Capacity;

for(int = 0; int < arrList.Count; i++)
{
    Console.Write($" | {arrList[i]}");
}

//recursos importantes de lista
//verificar seum valor écontido na lista
bool contemNome = arrList.Contais("Ryan");
if(contemNome)
    Consol.WriteLine("Nome Mauricio não encontrado");
    

//Para saber o índice que contem o valor buscado
//Neste caso, se o valor exitir na lista ele retorna o índice do numero inteiro. aso valor não exista na lista retorna -1

int indiceDoValor = arrtList.IndexOf("Ryan");
if(indiceDoValor >= 0)
    Console.WriteLine($"Ryan estáem [{indiceDoValor}]");
else
    Cosole.WriteLine("É,realmente não tem.")

//É possivel remover itens da liista
arrList.Remove("Ryan");
arrList.RemoveAt(4);//remove no índice
arrList.Remove(0,2);