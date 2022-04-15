using System;

namespace UnitTestExample
{
    public interface IAnswerRepository
    {
        double Get(int id);

        int? Persist(double answer, string comment);
    }
}