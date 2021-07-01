using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//add classe

using Microsoft.Speech.Synthesis;
using System.Windows.Forms;

namespace tcc
{
    class Fala
    {

        // codigo
        

        // objeto que gerencia a instancia dessa classe

        private static Fala GerenciaInstancia = null;


        /* implementação de um conceito de designer - singleton (assegura que a classe
           só vai ter uma instancia) */ 


        // 2º propriedade - assegura que nenhuma outra thread consiga acessar o método (Lock)

        private static object objLock = new object();


        /* objeto utilizado p trazer a referencia do botao da tela - p poder alterar o texto
           conforme a sintese estiver sendo executada */ 

        private static Button refBotao = null;



        // declaração de duas propriedades publicas - volume e velocidade

        public int Volume { get; set; }

        public int Velocidade { get; set; }



        //instancia do objeto utilizado p chamar os metodos

        SpeechSynthesizer SpeechEngine = new SpeechSynthesizer();


        //metodo que executa a sintese de voz

        public void Falar(string strTexto)
        {

            // atribuição de 2 propriedades p o objeto

            SpeechEngine.Rate = this.Velocidade;

            SpeechEngine.Volume = this.Volume;


            // adicionando um evento
            // StateChanged controla os estados da sintese (falando;pausado)

            SpeechEngine.StateChanged += SpeechEngine_StateChanged;
                

            //controle de execução da sintese

            if (!string.IsNullOrWhiteSpace(strTexto))
            {

                switch (SpeechEngine.State)
                {
 
                    case SynthesizerState.Ready:
                        SpeechEngine.SetOutputToDefaultAudioDevice(); // definindo o dispositivo padrao de reprodução da sintese
                        SpeechEngine.SpeakAsync(strTexto);
                        break;


                    case SynthesizerState.Speaking:
                        SpeechEngine.Pause();
                        break;


                    case SynthesizerState.Paused:
                        SpeechEngine.Resume();
                        break;

                }

            }

        }


        void SpeechEngine_StateChanged(object sender, StateChangedEventArgs e)
        {
            
            // criando chave p manipular esses estados

            switch (e.State)
            {

                case SynthesizerState.Ready:
                    refBotao.Text = "Falar";
                    break;


                case SynthesizerState.Speaking:
                    refBotao.Text = "Pausar";
                    break;


                case SynthesizerState.Paused:
                    refBotao.Text = "Continuar";
                    break;

            }


        }


        // implementação da forma de instancia dessa classe

        public static Fala getInstance(ref Button Botao)
        {
 
            // definir o metodo lock

            lock (objLock)
            {
 
                // tratar a instancia

                if (GerenciaInstancia == null)
                { 
                
                    // atribui uma instancia a essa classe

                    GerenciaInstancia = new Fala();

                    refBotao = Botao;

                }

                return GerenciaInstancia;

            }

        }

    }
}
