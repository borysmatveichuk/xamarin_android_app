using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedClassLibraryCSharp;
//using UtilityLibraries;

namespace QuestionRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetQuestions()
        {
            QuestionRepository repository = new QuestionRepository();
            Assert.AreEqual(repository.GetQuestions().Count, 5);
        }

        [TestMethod]
        public void TestGetQuestionContent()
        {
            QuestionRepository repository = new QuestionRepository();
            Assert.AreEqual(repository.GetFirstQuestion().Content, "What is your name?");
        }

        [TestMethod]
        public void TestGetFirstQuestion()
        {
            QuestionRepository repository = new QuestionRepository();
            Assert.AreEqual(repository.GetFirstQuestion().Id, "1");
        }

        [TestMethod]
        public void TestGetNextQuestion()
        {
            QuestionRepository repository = new QuestionRepository();
            var question = repository.GetNextQuestion(repository.GetFirstQuestion().Next);
            Assert.AreEqual(question.Id, "2");
        }

        [TestMethod]
        public void TestGetNullQuestion()
        {
            QuestionRepository repository = new QuestionRepository();
            var question = repository.GetNextQuestion("66");
            Assert.AreEqual(question, null);
        }

        [TestMethod]
        public void TestLastQuestion()
        {
            QuestionRepository repository = new QuestionRepository();
            var question = repository.GetFirstQuestion();
            Assert.AreEqual(question.IsLast(), false);

            var questionLast = repository.GetNextQuestion("5");
            Assert.AreEqual(questionLast.IsLast(), true);
        }
    }
}
