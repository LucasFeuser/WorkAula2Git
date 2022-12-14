using System; 

//Modificacao v2.1 FeatureX

namespace aula_02
{
    internal class Program
    {
        //Classes -------------------------------------------------------

        public class Criacao_Mapa{
            public string[,] mapa = new string[10,10]; //Criando o mapa

            public Criacao_Mapa(){
                for(int i = 0; i < 10; i++){
                    for(int j = 0; j < 10; j++){
                        mapa[i,j] = "--";
                    }
                }
            }
        }
    
    public static void printa_tudo(string coisa){
        for(int i = 0; i < 10; i++){
            for(int j = 0; j < 10; j++){
                Console.WriteLine(coisa[i,j]);
            }
            i--; // Modificacao 2.2
        }
    }
        //Chamando tudo -------------------------------------------------------
    public static void Main()
        {
            var jogo = new Criacao_Mapa();
                          
            printa_tudo(jogo.mapa);

        }  
    }      
}
//V1 - FIRST ALTERATION
//V2 - SECOND ALTERATION
//V3 - THIRDY ALTERATION

//V4 - VERSAO FINAL V4.0