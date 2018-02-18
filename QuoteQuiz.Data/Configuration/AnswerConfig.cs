namespace QuoteQuiz.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    internal class AnswerConfig : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Text)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode();

            builder.Property(a => a.IsCorrect)
                .IsRequired();
        }
    }
}
