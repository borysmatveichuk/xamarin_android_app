// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by Embeddinator-4000.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
#include "Mono.Android.h"
#include "glib.h"
#include "mono_embeddinator.h"
#include "c-support.h"

mono_embeddinator_context_t __mono_context;
MonoImage* __Mono_Android_dll_image;

static MonoClass* class_Android_App_Activity = 0;
static MonoClass* class_Android_App_PendingIntentFlags = 0;
static MonoClass* class_Android_Content_FileCreationMode = 0;
static MonoClass* class_Android_Views_Keycode = 0;
static MonoClass* class_Android_Content_PM_Permission = 0;
static MonoClass* class_Android_Content_TrimMemory = 0;
static MonoClass* class_Android_Views_ActionModeType = 0;
static MonoClass* class_Android_Views_WindowFeatures = 0;
static MonoClass* class_Android_App_DefaultKey = 0;
static MonoClass* class_Android_App_Result = 0;
static MonoClass* class_Android_Content_ActivityFlags = 0;
static MonoClass* class_Android_Views_ContextThemeWrapper = 0;
static MonoClass* class_Android_Content_ContextWrapper = 0;
static MonoClass* class_Android_Content_Bind = 0;
static MonoClass* class_Android_Content_PackageContextFlags = 0;
static MonoClass* class_Android_Content_Context = 0;
static MonoClass* class_Java_Lang_Object = 0;
static MonoClass* class_Android_Runtime_JniHandleOwnership = 0;
static MonoClass* class_Java_Interop_JniManagedPeerStates = 0;
static MonoClass* class_System_IDisposable = 0;
static MonoClass* class_Android_Runtime_IJavaObject = 0;
static MonoClass* class_Java_Interop_IJavaObjectEx = 0;
static MonoClass* class_Java_Interop_IJavaPeerable = 0;
static MonoClass* class_Android_Content_IComponentCallbacks = 0;
static MonoClass* class_Android_Content_IComponentCallbacks2 = 0;
static MonoClass* class_Android_Views_ICallback = 0;
static MonoClass* class_Android_Views_IFactory = 0;
static MonoClass* class_Android_Views_IFactory2 = 0;
static MonoClass* class_Android_Views_IOnCreateContextMenuListener = 0;
static MonoClass* class_Android_Content_PM_ConfigChanges = 0;
static MonoClass* class_Android_Content_PM_ScreenOrientation = 0;
static MonoClass* class_Android_Media_Stream = 0;

static void __initialize_mono()
{
    if (__mono_context.domain)
        return;
    mono_embeddinator_init(&__mono_context, "mono_embeddinator_binding");
}

static void __lookup_assembly_Mono_Android_dll()
{
    if (__Mono_Android_dll_image)
        return;
    __Mono_Android_dll_image = mono_embeddinator_load_assembly(&__mono_context, "Mono.Android.dll");
}
