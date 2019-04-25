using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Arch.Lifecycle;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Model;
using SharedClassLibraryCSharp;
using Xamarin.Essentials;

namespace App1Android
{
    public class MainViewModel : ViewModel
    {
        private QuestionRepository repo;
        private int totalScore = 0;

        public BehaviorSubject<Question> subjectQuestion;

        public MainViewModel()
        {
            repo = new QuestionRepository();
            subjectQuestion = new BehaviorSubject<Question>(repo.GetFirstQuestion());
           
        }

        public List<Question> GetQuestions()
        {            
            List<Question> questions = new List<Question>();
            questions = repo.GetQuestions();

            return questions;
        }

        public void SetCurrentAnswer(Answer answer)
        {
            totalScore += answer.Points;
            subjectQuestion.OnNext(repo.GetNextQuestion(answer.Next));
        }

        public void SetCurrentQuestion(Question question)
        {
            totalScore += question.Points ?? default;
            subjectQuestion.OnNext(repo.GetNextQuestion(question.Next));
        }

        public int GetTotalScore()
        {
            return totalScore;
        }

    }
}