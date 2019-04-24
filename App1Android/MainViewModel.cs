﻿using System;
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
    class MainViewModel : ViewModel
    {
        private QuestionRepository repo;

        public BehaviorSubject<Question> subjectQuestion;

        public MainViewModel()
        {
            repo = new QuestionRepository();
            subjectQuestion = new BehaviorSubject<Question>(repo.GetNextQuestion("2"));
           
        }

        public List<Question> GetQuestions()
        {            
            List<Question> questions = new List<Question>();
            questions = repo.GetQuestions();

            return questions;
        }

    }
}