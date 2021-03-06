﻿using System;

using Android.Arch.Lifecycle;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace App1Android
{
    public class FragmentFinish : FragmentBase
    {
        public static FragmentFinish NewInstance()
        {
            FragmentFinish Fragment = new FragmentFinish();
            return Fragment;           
        }

        private TextView scoreText;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_finish, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            scoreText = view.FindViewById<TextView>(Resource.Id.score);
            scoreText.Text = view.Context.GetString(Resource.String.your_score, viewModel.GetTotalScore());
        }
    }
}