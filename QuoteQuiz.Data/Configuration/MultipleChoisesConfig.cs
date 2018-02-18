namespace QuoteQuiz.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    internal class MultipleChoisesConfig : IEntityTypeConfiguration<MultipleChoisesQuestion>
    {
        public void Configure(EntityTypeBuilder<MultipleChoisesQuestion> builder)
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

            builder.HasMany(q => q.Answers)
                .WithOne(q => q.Question)
                .HasForeignKey(a => a.QuestionId);
        }
    }
}
