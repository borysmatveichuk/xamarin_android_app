using Android.Arch.Lifecycle;
using Android.OS;
using Android.Support.V4.App;

namespace App1Android
{
    public abstract class FragmentBase: Fragment
    {
        
        protected MainViewModel viewModel;
     
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);    
            viewModel = ViewModelProviders.Of(Activity).Get(Java.Lang.Class.FromType(typeof(MainViewModel))) as MainViewModel;
        }
        
    }
}