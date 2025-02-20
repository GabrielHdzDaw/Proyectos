using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiccionarioKlingon
{
    internal class Diccionario
    {
        static Dictionary<string, string> spanishToKlingonPhrases = new Dictionary<string, string>
            {
                { "¡Éxito!", "Qapla'!" },
                { "Hoy, ¿qué quieres?", "jIyaj, nuqneH?" },
                { "Entiendo la lengua klingon.", "tlhIngan Hol yIghoS." },
                { "Bien, ¡cuidado!", "maj, qaStaHvIS!" },
                { "Gracias, amigo.", "yIchuq, ghobe'." },
                { "Hoy es un buen día para morir.", "Heghlu'meH QaQ jajvam." },
                { "Victoria, ¿dónde está el baño?", "bortaS, nuqDaq 'oH puchpa''e'?" },
                { "Honor y respeto.", "batlh yIghun." },
                { "¡Entendido! No.", "DaHjaj, Qo'." },
                { "Amigo, gracias.", "ghobe' yIchuq." },
                { "Sí, yo soy klingon.", "HIja', jIH tlhIngan." },
                { "No, tú eres el enemigo.", "Qo', SoH qaStaH." },
                { "Entiendo la comida.", "ghorgh yIghoS." },
                { "Enemigo, gracias.", "qaStaH yIchuq." },
                { "El klingon es un guerrero.", "tlhInganwo' bIQ'a'." },
                { "Sangre y respeto.", "bIQ yIghun." },
                { "Entiendo el corazón.", "Quch yIghoS." },
                { "Familia, gracias.", "HIvje yIchuq." },
                { "Casa y respeto.", "tlhIH yIghun." },
                { "Entiendo el honor.", "qagh yIghoS." },
                { "Luchar, gracias.", "yItIv yIchuq." },
                { "Guerrero honorable, respeto.", "bIQ'a'moH yIghun." },
                { "Éxito honorable, gracias.", "Qapla'moH yIchuq." },
                { "Entiendo el idioma klingon.", "tlhInganpu' yIghoS." },
                { "Gracias honorable, respeto.", "yIchuqmoH yIghun." },
                { "Entiendo al guerrero klingon.", "bIQ'a'pu' yIghoS." },
                { "Éxito klingon, gracias.", "Qapla'pu' yIchuq." },
                { "Hogar honorable, respeto.", "tlhIHvammoH yIghun." },
                { "Respeto honorable, gracias.", "yIghunmoH yIchuq." },
                { "Entiendo al guerrero honorable klingon.", "bIQ'a'moHpu' yIghoS." },
                { "Éxito honorable klingon, gracias.", "Qapla'moHpu' yIchuq." },
                { "Idioma klingon honorable, respeto.", "tlhInganpu'moH yIghun." },
                { "Entiendo las gracias honorables klingon.", "yIchuqmoHpu' yIghoS." },
                { "Guerrero klingon honorable, gracias.", "bIQ'a'pu'moH yIchuq." },
                { "Éxito klingon honorable, respeto.", "Qapla'pu'moH yIghun." },
                { "Entiendo el hogar honorable klingon.", "tlhIHvammoHpu' yIghoS." },
                { "Respeto honorable klingon, gracias.", "yIghunmoHpu' yIchuq." }
            };
        public Diccionario()
        {

        }

        

        public static string Traducir(string frase)
        {
            string res = "";
            string[] frases = frase.Split(". ");

            foreach (string s in frases)
            {
                string ss = s + ".";
                ss = ss.Replace("..", ".");
                
                if (spanishToKlingonPhrases.ContainsKey(ss))
                {
                    res += spanishToKlingonPhrases[ss] + " ";
                }
            }
            if (res == "")
            {
                res = frase;
            }
            return res;
        }
    }
}
