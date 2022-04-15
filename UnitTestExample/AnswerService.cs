using System;

namespace UnitTestExample
{
    public class AnswerService
    {
        private readonly IAnswerRepository repository;
        private readonly IAnswerReporter reporter;

        public AnswerService(IAnswerRepository repository, IAnswerReporter reporter)
        {
            this.repository = repository;
            this.reporter = reporter;
        }

        public void Save(double answer)
        {
            var id = repository.Persist(answer, "This is my answer.");

            if (id.HasValue)
            {
                reporter.Report(id.Value);
            }
            else
            {
                throw new InvalidOperationException("id must be not null!");
            }
        }
    }
}