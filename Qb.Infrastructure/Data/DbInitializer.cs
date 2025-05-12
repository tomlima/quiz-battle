using Qb.Domain.Entities;
using Qb.Domain.Enums;
namespace Qb.Infrastructure.Data;
using BCrypt.Net;

public class DbInitializer
{
    public static void Seed(ApplicationDbContext context)
    {
        
        /*
         * Users instances
         * And creation
         */
        User U_1 = new User
        {
            Name = "admin", 
            Email = "tom.lima@nzn.io", 
            Password = BCrypt.HashPassword("123456"), 
            Role = Roles.Admin, 
            Status = true, 
            CreatedAt = DateTime.Now, 
            Nickname = "NZN",
            Avatar = "default.png"
        };
        
        if (!context.Users.Any())
        {
            context.Users.AddRange(U_1);
            context.SaveChanges(); 
        }
        
      
        /*
         * Categories instances
         * And creation
         */
        Category C_serie = new Category {  Name = "Séries", Slug = "series", Icon = "serie"};
        Category C_movie = new Category {  Name = "Filmes", Slug = "filmes", Icon = "movie"};
        Category C_game = new Category {   Name = "Games", Slug = "games", Icon = "game"};
        
        if (!context.Categories.Any())
        {
            context.Categories.AddRange(C_serie, C_movie, C_game);
            context.SaveChanges(); 
        }
        
        
        /*
         * Quizzes instances
         * And creation
         */
        Quiz QZ_1 = new Quiz
        {
            Title = "Basic Harry Potter Quiz",
            Difficulty = Difficulty.Easy,
            Description = "Conhecimentos básicos sobre o universo de Harry Potter",
            Questions = new List<Question>(),
            Status = QuizStatus.Active,
            CreatedAt = DateTime.Now,
            Featured = true,
            Category = C_movie,
            Image = "hp.png",
            Time = 5
        };
        
        if (!context.Quizzes.Any())
        {
            context.Quizzes.AddRange(QZ_1);
            context.SaveChanges(); 
        }
        
        /*
         * Questions instances
         * And creation
         */
        Question Q_1 = new Question
        {
            Text = "Qual é o nome completo do protagonista da série?",
            Answers =new List<Answer>(),
            Difficulty = Difficulty.Easy,
            Order = 1,
            QuizId = QZ_1.Id,
        };
        
        Question Q_2 = new Question
        {
            Text = "Qual é a casa de Harry em Hogwarts?",
            Answers = new List<Answer>(),
            Difficulty = Difficulty.Easy,
            Order = 2,
            QuizId = QZ_1.Id,
        };
        
        Question Q_3 = new Question
        {
            Text = "Quem é o diretor de Hogwarts na maior parte da série?",
            Answers = new List<Answer>(),
            Difficulty = Difficulty.Easy,
            Order = 3,
            QuizId = QZ_1.Id,
        };
        
        if (!context.Questions.Any())
        {
            context.Questions.AddRange(Q_1,Q_2,Q_3);
            context.SaveChanges();
        }
        
        
        
        /*
         * Answer instances
         * And creation
         */
        Answer A_1 = new Answer { Text = "Harry James Potter", Correct = true, QuestionId = Q_1.Id};
        Answer A_2 = new Answer { Text = "Harold John Potter", Correct = false, QuestionId = Q_1.Id };
        Answer A_3 = new Answer { Text = "Henry Jacob Potter", Correct = false, QuestionId = Q_1.Id };
        Answer A_4 = new Answer { Text = "Harry Sirius Potter", Correct = false, QuestionId = Q_1.Id };
        
        Answer A_5 = new Answer { Text = "Sonserina", Correct = false, QuestionId = Q_2.Id };
        Answer A_6 = new Answer { Text = "Corvinal", Correct = false, QuestionId = Q_2.Id };
        Answer A_7 = new Answer { Text = "Grifinória ", Correct = true, QuestionId = Q_2.Id };
        Answer A_8 = new Answer { Text = "Lufa-Lufa ", Correct = false, QuestionId = Q_2.Id };
        
        Answer A_9 = new Answer { Text = "Severus Snape", Correct = false, QuestionId = Q_3.Id };
        Answer A_10 = new Answer { Text = "Alvo Dumbledore", Correct = true ,QuestionId = Q_3.Id };
        Answer A_11 = new Answer { Text = "Minerva McGonagall ", Correct = false,QuestionId = Q_3.Id };
        Answer A_12 = new Answer { Text = "Gellert Grindelwald ", Correct = false,QuestionId = Q_3.Id };
        
        // Insert answers
        if (!context.Answers.Any())
        {
            context.Answers.AddRange(A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12);
            context.SaveChanges();
        }

    }
}