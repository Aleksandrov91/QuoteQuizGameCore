namespace QuoteQuiz.Data
{
    using Microsoft.EntityFrameworkCore;

    using Configuration;
    using Models;

    public class QuoteQuizContext : DbContext
    {
        public QuoteQuizContext(DbContextOptions<QuoteQuizContext> options)
            : base(options)
        {
        }

        public DbSet<MultipleChoisesQuestion> MultipleAnswerQuesitons { get; set; }

        public DbSet<OneChoiseQuestion> OneChoiseQuestion { get; set; }

        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AnswerConfig());
            builder.ApplyConfiguration(new MultipleChoisesConfig());
            builder.ApplyConfiguration(new OneChoiseQuestionConfig());
        }
    }
}
