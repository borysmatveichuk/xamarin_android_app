using Android.Arch.Lifecycle;
using Android.OS;
using Android.Support.V4.App;
using System;
using Java.Lang;

namespace App1Android
{
    public abstract class FragmentBase: Fragment
    {
        
        protected MainViewModel viewModel;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);    
            viewModel = ViewModelProviders.Of(Activity).Get(Class.FromType(typeof(MainViewModel))) as MainViewModel;
        }

    }
}