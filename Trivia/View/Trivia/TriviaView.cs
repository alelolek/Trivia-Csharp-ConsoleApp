﻿using Business.Implementations;
using Business.Interfaces;
using CrossCutting.Dto;
using CrossCutting.Enum;

namespace Presentation.View.Trivia
{
    public class TriviaView
    {
        private readonly IQuestionService _questionService;

        public TriviaView()
        {
            _questionService = new QuestionService();
        }

        public void Start()
        {
            StartMessage();
            var categoryInput = ShowCategory();

            if (Enum.TryParse(categoryInput, out Category category))
                StartTrivia(category);
            else
                Console.WriteLine("Opcion Invalida");
        }

        public void Vuelta()
        {
			var categoryInput = ShowCategory();

			if (Enum.TryParse(categoryInput, out Category category))
				StartTrivia(category);
			else
				Console.WriteLine("Opcion Invalida");
		}
	
        private void StartTrivia(Category category)
        {
            var listaPreguntas = _questionService.ListQuestionByCategory(category);
            ShowQuestion(listaPreguntas);

        }
        private string ShowAnswer(List<Answer> listAnswer)
        {
            foreach (var respuestas in listAnswer)
            {
                Console.WriteLine($"{respuestas.Id}.- {respuestas.Description}");
            }

            Console.Write("Escoge una respuesta: ");
            var respuestausuario = Console.ReadLine();
            return respuestausuario;
        }
        private void ShowQuestion(List<Question> listQuestion)
        {
            var score = 0;
            foreach (var pregunta in listQuestion)
            {
                Console.WriteLine($"{pregunta.Description}");
                var answerInput = ShowAnswer(pregunta.Answers);
                if (ValidateAnswer(answerInput, pregunta.Answers))
                {
                    Console.WriteLine("Respuesta Correcta");
                    score++;
                }
                else
                {
                    Console.WriteLine("Respuesta Inorrecta");
                    score--;
                }
            }
            ScoreMessage(score);
        }
        
        private bool ValidateAnswer(string answer, List<Answer> listAnswer)
        {
            bool isCorrect = false;
            foreach (var respuestas in listAnswer)
            {
                if (answer == respuestas.Id.ToString() && respuestas.IsValid)
                {
                    isCorrect= true;
                }
               
            }
            return isCorrect;
        }
        
        private void StartMessage()
        {
            Console.WriteLine("Bienvedido a la trivia de Programación, Ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Muy bien {nombre} empecemos la trivia...");
            Console.WriteLine("Pero recuerda por cada respuesta fallida se descontara un punto!");
        }

        private string ShowCategory()
        {
            Console.WriteLine("Ingresa una categoria:");
            Console.WriteLine("1.- Desarrollo Web");
            Console.WriteLine("2.- Desarrollo Móvil");
			Console.WriteLine("3.- Ciencia de Datos");
			Console.WriteLine("4.- Seguridad Informática");
			var categoryInput = Console.ReadLine();
            return categoryInput;
        }

        private void ScoreMessage(int questionCorrect)
        {
            Console.WriteLine($"Puntaje final: {questionCorrect}");
            if (questionCorrect >= 3)
                Console.WriteLine("¡Felicitaciones! Has obtenido una excelente puntuación y has ganado la trivia de programación. ¡Eres un experto en el tema! ");
            else
                Console.WriteLine("Lo siento, no has logrado obtener la puntuación suficiente para ganar la trivia. ¡No te desanimes! Puedes seguir aprendiendo y mejorando!");

            Console.WriteLine("Quieres volverlo a intentar? escribe Si");
            string continuar= Console.ReadLine();
			if (continuar == "Si")
                Vuelta();
            else
                Console.WriteLine("Hasta luego, Te espero pronto!");
        }
    }
}
