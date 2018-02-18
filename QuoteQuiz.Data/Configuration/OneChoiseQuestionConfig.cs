namespace QuoteQuiz.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    internal class OneChoiseQuestionConfig : IEntityTypeConfiguration<OneChoiseQuestion>
    {
        public void Configure(EntityTypeBuilder<OneChoiseQuestion> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Text)
                .HasMaxLength(200)
                .IsRequired()
                .IsUnicode();

            builder.Property(q => q.Author)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

            builder.Property(q => q.Correct)
                .IsRequired();
        }
    }
}
