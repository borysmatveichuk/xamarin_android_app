// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by Embeddinator-4000.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
#include "mscorlib.h"
#include "glib.h"
#include "mono_embeddinator.h"
#include "c-support.h"

mono_embeddinator_context_t __mono_context;
MonoImage* __mscorlib_dll_image;

static MonoClass* class_System_IDisposable = 0;

static void __initialize_mono()
{
    if (__mono_context.domain)
        return;
    mono_embeddinator_init(&__mono_context, "mono_embeddinator_binding");
}

static void __lookup_assembly_mscorlib_dll()
{
    if (__mscorlib_dll_image)
        return;
    __mscorlib_dll_image = mono_embeddinator_load_assembly(&__mono_context, "mscorlib.dll");
}

static void __lookup_class_System_IDisposable()
{
    if (class_System_IDisposable == 0)
    {
        __initialize_mono();
        __lookup_assembly_mscorlib_dll();
        class_System_IDisposable = mono_class_from_name(__mscorlib_dll_image, "System", "IDisposable");
    }
}

void System_IDisposable_Dispose(System_IDisposable* object)
{
    const char __method_name[] = "System.IDisposable:Dispose()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_System_IDisposable();
        __method = mono_embeddinator_lookup_method(__method_name, class_System_IDisposable);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}