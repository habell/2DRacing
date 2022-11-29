#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// Readme/Section[]
struct SectionU5BU5D_t9D3017555FFF42E71BE91904A2486EAF429F24C4;
// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3;
// _Root.CodeBase.Services.Input.DefaultInputService
struct DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE;
// _Root.CodeBase.Infrastructure.Game
struct Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E;
// _Root.CodeBase.Infrastructure.GameBootstrapper
struct GameBootstrapper_tD5511020814F864DDB79CEEEE2B6486DE9F74B93;
// _Root.CodeBase.Services.Input.IInputService
struct IInputService_tF48D9EF17E290D8849CB80F839C386681C795764;
// _Root.CodeBase.Services.Input.InputService
struct InputService_tF31DFC1696C960EE430604A000A6A2A785697286;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71;
// Readme
struct Readme_tE17B99201D0F52BD5727638AD3F41072A65B3BBB;
// UnityEngine.RectTransform
struct RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5;
// UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A;
// System.String
struct String_t;
// _Root.CodeBase.GamePlay.TailRender
struct TailRender_tEF5CE6E2641930BAEC0624DF292C9EE63297120C;
// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// Readme/Section
struct Section_t50C894D0A717C2368EBAAE5477D4E8626D0B5401;
// UnityEngine.RectTransform/ReapplyDrivenProperties
struct ReapplyDrivenProperties_t3482EA130A01FF7EE2EEFE37F66A5215D08CFE24;

IL2CPP_EXTERN_C RuntimeClass* DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IInputService_tF48D9EF17E290D8849CB80F839C386681C795764_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral265E15F1F86F1C766555899D5771CF29055DE75A;
IL2CPP_EXTERN_C String_t* _stringLiteral7F8C014BD4810CC276D0F9F81A1E759C7B098B1E;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m0640480E7E38BB88B0D1F6AD59E697C8EE6AAFA4_RuntimeMethod_var;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tBB65183F1134474D09FF49B95625D25472B9BA8B 
{
};
struct Il2CppArrayBounds;

// _Root.CodeBase.Infrastructure.Game
struct Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E  : public RuntimeObject
{
};

struct Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_StaticFields
{
	// _Root.CodeBase.Services.Input.IInputService _Root.CodeBase.Infrastructure.Game::_inputService
	RuntimeObject* ____inputService_0;
};

// _Root.CodeBase.Services.Input.InputService
struct InputService_tF31DFC1696C960EE430604A000A6A2A785697286  : public RuntimeObject
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// Readme/Section
struct Section_t50C894D0A717C2368EBAAE5477D4E8626D0B5401  : public RuntimeObject
{
	// System.String Readme/Section::heading
	String_t* ___heading_0;
	// System.String Readme/Section::text
	String_t* ___text_1;
	// System.String Readme/Section::linkText
	String_t* ___linkText_2;
	// System.String Readme/Section::url
	String_t* ___url_3;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// _Root.CodeBase.Services.Input.DefaultInputService
struct DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE  : public InputService_tF31DFC1696C960EE430604A000A6A2A785697286
{
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 
{
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;
};

struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields
{
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___negativeInfinityVector_9;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};

struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};
// Native definition for P/Invoke marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A_marshaled_pinvoke : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A_marshaled_com : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// Readme
struct Readme_tE17B99201D0F52BD5727638AD3F41072A65B3BBB  : public ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A
{
	// UnityEngine.Texture2D Readme::icon
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___icon_4;
	// System.String Readme::title
	String_t* ___title_5;
	// Readme/Section[] Readme::sections
	SectionU5BU5D_t9D3017555FFF42E71BE91904A2486EAF429F24C4* ___sections_6;
	// System.Boolean Readme::loadedLayout
	bool ___loadedLayout_7;
};

// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// UnityEngine.RectTransform
struct RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5  : public Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1
{
};

struct RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_StaticFields
{
	// UnityEngine.RectTransform/ReapplyDrivenProperties UnityEngine.RectTransform::reapplyDrivenProperties
	ReapplyDrivenProperties_t3482EA130A01FF7EE2EEFE37F66A5215D08CFE24* ___reapplyDrivenProperties_4;
};

// _Root.CodeBase.Infrastructure.GameBootstrapper
struct GameBootstrapper_tD5511020814F864DDB79CEEEE2B6486DE9F74B93  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// _Root.CodeBase.Infrastructure.Game _Root.CodeBase.Infrastructure.GameBootstrapper::_game
	Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E* ____game_4;
};

// _Root.CodeBase.GamePlay.TailRender
struct TailRender_tEF5CE6E2641930BAEC0624DF292C9EE63297120C  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// _Root.CodeBase.Services.Input.IInputService _Root.CodeBase.GamePlay.TailRender::_inputService
	RuntimeObject* ____inputService_4;
	// UnityEngine.RectTransform _Root.CodeBase.GamePlay.TailRender::_rectTransform
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ____rectTransform_5;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif


// T UnityEngine.Component::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;

// System.Void UnityEngine.ScriptableObject::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScriptableObject__ctor_mD037FDB0B487295EA47F79A4DB1BF1846C9087FF (ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A* __this, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector2 _Root.CodeBase.Services.Input.DefaultInputService::GetUnityAxis()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 DefaultInputService_GetUnityAxis_mE33BC6F60F5D15B0DC58BF99BF9F2C9861E8E6FA (DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Input::GetMouseButton(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetMouseButton_m4995DD4A2D4F916565C1B1B5AAF7DF17C126B3EA (int32_t ___button0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Input::GetMouseButtonUp(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetMouseButtonUp_mBE89CC9C69BBEA9A863819E77EA54411B0476ED6 (int32_t ___button0, const RuntimeMethod* method) ;
// System.Single UnityEngine.Input::GetAxis(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Input_GetAxis_m10372E6C5FF591668D2DC5F58C58D213CC598A62 (String_t* ___axisName0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___x0, float ___y1, const RuntimeMethod* method) ;
// System.Void _Root.CodeBase.Services.Input.InputService::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InputService__ctor_m750B5E5375B35C27CABC46BE159ACD8B8B730F43 (InputService_tF31DFC1696C960EE430604A000A6A2A785697286* __this, const RuntimeMethod* method) ;
// _Root.CodeBase.Services.Input.IInputService _Root.CodeBase.Infrastructure.Game::RegisterInputService()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Game_RegisterInputService_mA42D6E773205C5847B80EEA39168B534EC2A4FEA (Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E* __this, const RuntimeMethod* method) ;
// System.Void _Root.CodeBase.Services.Input.DefaultInputService::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DefaultInputService__ctor_m7FA0C449046D85A4A3F27781D1E0838AC15F54D6 (DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE* __this, const RuntimeMethod* method) ;
// System.Void _Root.CodeBase.Infrastructure.Game::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Game__ctor_m435D5FE20B24BE830E3AB8EDBF39A1EC868F1C55 (Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Input::get_mousePosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C (const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::print(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour_print_m9E6FF71C673B651F35DD418C293CFC50C46803B6 (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponent<UnityEngine.RectTransform>()
inline RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* Component_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m0640480E7E38BB88B0D1F6AD59E697C8EE6AAFA4 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// _Root.CodeBase.Services.Input.IInputService _Root.CodeBase.Infrastructure.Game::get_Service()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Game_get_Service_m96C13F81CAEAEA5FBA2CA90A7FD61971BA9D3DC1_inline (const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___value0, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Readme::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Readme__ctor_m69C325C4C171DCB0312B646A9034AA91EA8C39C6 (Readme_tE17B99201D0F52BD5727638AD3F41072A65B3BBB* __this, const RuntimeMethod* method) 
{
	{
		ScriptableObject__ctor_mD037FDB0B487295EA47F79A4DB1BF1846C9087FF(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Readme/Section::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Section__ctor_m5F732533E4DFC0167D965E5F5DB332E46055399B (Section_t50C894D0A717C2368EBAAE5477D4E8626D0B5401* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Vector2 _Root.CodeBase.Services.Input.DefaultInputService::get_Axis()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 DefaultInputService_get_Axis_m05D4419D25EC5AD6A391D208743E7E5B456D58E4 (DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE* __this, const RuntimeMethod* method) 
{
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var axis = GetUnityAxis();
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0;
		L_0 = DefaultInputService_GetUnityAxis_mE33BC6F60F5D15B0DC58BF99BF9F2C9861E8E6FA(__this, NULL);
		V_0 = L_0;
		// return axis;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = V_0;
		V_1 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		// }
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_2 = V_1;
		return L_2;
	}
}
// System.Boolean _Root.CodeBase.Services.Input.DefaultInputService::IsActionButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool DefaultInputService_IsActionButton_m4C623C39240198DB9AF42C3337DAC845F848FE71 (DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE* __this, const RuntimeMethod* method) 
{
	{
		// public override bool IsActionButton() => UnityEngine.Input.GetMouseButton(0);
		bool L_0;
		L_0 = Input_GetMouseButton_m4995DD4A2D4F916565C1B1B5AAF7DF17C126B3EA(0, NULL);
		return L_0;
	}
}
// System.Boolean _Root.CodeBase.Services.Input.DefaultInputService::IsActionButtonUp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool DefaultInputService_IsActionButtonUp_m92EA26301BB7E777D467E1E03E5DC38ED0B7E1F0 (DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE* __this, const RuntimeMethod* method) 
{
	{
		// public override bool IsActionButtonUp() => UnityEngine.Input.GetMouseButtonUp(0);
		bool L_0;
		L_0 = Input_GetMouseButtonUp_mBE89CC9C69BBEA9A863819E77EA54411B0476ED6(0, NULL);
		return L_0;
	}
}
// UnityEngine.Vector2 _Root.CodeBase.Services.Input.DefaultInputService::GetUnityAxis()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 DefaultInputService_GetUnityAxis_mE33BC6F60F5D15B0DC58BF99BF9F2C9861E8E6FA (DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral265E15F1F86F1C766555899D5771CF29055DE75A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7F8C014BD4810CC276D0F9F81A1E759C7B098B1E);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private Vector2 GetUnityAxis() => new(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical"));
		float L_0;
		L_0 = Input_GetAxis_m10372E6C5FF591668D2DC5F58C58D213CC598A62(_stringLiteral7F8C014BD4810CC276D0F9F81A1E759C7B098B1E, NULL);
		float L_1;
		L_1 = Input_GetAxis_m10372E6C5FF591668D2DC5F58C58D213CC598A62(_stringLiteral265E15F1F86F1C766555899D5771CF29055DE75A, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_2;
		memset((&L_2), 0, sizeof(L_2));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_2), L_0, L_1, /*hidden argument*/NULL);
		return L_2;
	}
}
// System.Void _Root.CodeBase.Services.Input.DefaultInputService::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DefaultInputService__ctor_m7FA0C449046D85A4A3F27781D1E0838AC15F54D6 (DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE* __this, const RuntimeMethod* method) 
{
	{
		InputService__ctor_m750B5E5375B35C27CABC46BE159ACD8B8B730F43(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void _Root.CodeBase.Services.Input.InputService::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InputService__ctor_m750B5E5375B35C27CABC46BE159ACD8B8B730F43 (InputService_tF31DFC1696C960EE430604A000A6A2A785697286* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void _Root.CodeBase.Infrastructure.Game::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Game__ctor_m435D5FE20B24BE830E3AB8EDBF39A1EC868F1C55 (Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public Game()
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// _inputService ??= RegisterInputService();
		RuntimeObject* L_0 = ((Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_StaticFields*)il2cpp_codegen_static_fields_for(Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var))->____inputService_0;
		if (L_0)
		{
			goto IL_001a;
		}
	}
	{
		RuntimeObject* L_1;
		L_1 = Game_RegisterInputService_mA42D6E773205C5847B80EEA39168B534EC2A4FEA(__this, NULL);
		((Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_StaticFields*)il2cpp_codegen_static_fields_for(Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var))->____inputService_0 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&((Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_StaticFields*)il2cpp_codegen_static_fields_for(Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var))->____inputService_0), (void*)L_1);
	}

IL_001a:
	{
		// }
		return;
	}
}
// _Root.CodeBase.Services.Input.IInputService _Root.CodeBase.Infrastructure.Game::get_Service()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Game_get_Service_m96C13F81CAEAEA5FBA2CA90A7FD61971BA9D3DC1 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public static IInputService Service => _inputService;
		RuntimeObject* L_0 = ((Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_StaticFields*)il2cpp_codegen_static_fields_for(Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var))->____inputService_0;
		return L_0;
	}
}
// _Root.CodeBase.Services.Input.IInputService _Root.CodeBase.Infrastructure.Game::RegisterInputService()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Game_RegisterInputService_mA42D6E773205C5847B80EEA39168B534EC2A4FEA (Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private IInputService RegisterInputService() => new DefaultInputService();
		DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE* L_0 = (DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE*)il2cpp_codegen_object_new(DefaultInputService_t752C5FD6C5186F8C4162BEEB6758296002A8D1AE_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		DefaultInputService__ctor_m7FA0C449046D85A4A3F27781D1E0838AC15F54D6(L_0, NULL);
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void _Root.CodeBase.Infrastructure.GameBootstrapper::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameBootstrapper_Awake_m39563E7A94ACAE9BB39FF5AC3C09B3B55626A76F (GameBootstrapper_tD5511020814F864DDB79CEEEE2B6486DE9F74B93* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// _game = new Game();
		Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E* L_0 = (Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E*)il2cpp_codegen_object_new(Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		Game__ctor_m435D5FE20B24BE830E3AB8EDBF39A1EC868F1C55(L_0, NULL);
		__this->____game_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____game_4), (void*)L_0);
		// }
		return;
	}
}
// System.Void _Root.CodeBase.Infrastructure.GameBootstrapper::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameBootstrapper_Update_m0F9A57CE77469C517714C4550E833ABF110AF135 (GameBootstrapper_tD5511020814F864DDB79CEEEE2B6486DE9F74B93* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		// if (Input.GetMouseButtonUp(0))
		bool L_0;
		L_0 = Input_GetMouseButtonUp_mBE89CC9C69BBEA9A863819E77EA54411B0476ED6(0, NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001d;
		}
	}
	{
		// print(Input.mousePosition);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = L_2;
		RuntimeObject* L_4 = Box(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var, &L_3);
		MonoBehaviour_print_m9E6FF71C673B651F35DD418C293CFC50C46803B6(L_4, NULL);
	}

IL_001d:
	{
		// }
		return;
	}
}
// System.Void _Root.CodeBase.Infrastructure.GameBootstrapper::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameBootstrapper__ctor_mE2FF5C61881B5E4283BDBE9C93124F31A41CD1B7 (GameBootstrapper_tD5511020814F864DDB79CEEEE2B6486DE9F74B93* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void _Root.CodeBase.GamePlay.TailRender::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TailRender_Awake_m4387AFC83060B242B03AA08A69A754304FA030BB (TailRender_tEF5CE6E2641930BAEC0624DF292C9EE63297120C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m0640480E7E38BB88B0D1F6AD59E697C8EE6AAFA4_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// _rectTransform = GetComponent<RectTransform>();
		RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* L_0;
		L_0 = Component_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m0640480E7E38BB88B0D1F6AD59E697C8EE6AAFA4(__this, Component_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m0640480E7E38BB88B0D1F6AD59E697C8EE6AAFA4_RuntimeMethod_var);
		__this->____rectTransform_5 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____rectTransform_5), (void*)L_0);
		// }
		return;
	}
}
// System.Void _Root.CodeBase.GamePlay.TailRender::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TailRender_Start_mA5359E5B522275BE09F2E76B7D43606E6998D5B9 (TailRender_tEF5CE6E2641930BAEC0624DF292C9EE63297120C* __this, const RuntimeMethod* method) 
{
	{
		// _inputService = Game.Service;
		RuntimeObject* L_0;
		L_0 = Game_get_Service_m96C13F81CAEAEA5FBA2CA90A7FD61971BA9D3DC1_inline(NULL);
		__this->____inputService_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____inputService_4), (void*)L_0);
		// }
		return;
	}
}
// System.Void _Root.CodeBase.GamePlay.TailRender::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TailRender_Update_m3961B7C818FDD19A465320DFED23104790EE5B25 (TailRender_tEF5CE6E2641930BAEC0624DF292C9EE63297120C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IInputService_tF48D9EF17E290D8849CB80F839C386681C795764_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		// if(_inputService.IsActionButton()) _rectTransform.position = Input.mousePosition ;
		RuntimeObject* L_0 = __this->____inputService_4;
		NullCheck(L_0);
		bool L_1;
		L_1 = InterfaceFuncInvoker0< bool >::Invoke(2 /* System.Boolean _Root.CodeBase.Services.Input.IInputService::IsActionButton() */, IInputService_tF48D9EF17E290D8849CB80F839C386681C795764_il2cpp_TypeInfo_var, L_0);
		V_0 = L_1;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0021;
		}
	}
	{
		// if(_inputService.IsActionButton()) _rectTransform.position = Input.mousePosition ;
		RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* L_3 = __this->____rectTransform_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		NullCheck(L_3);
		Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156(L_3, L_4, NULL);
	}

IL_0021:
	{
		// }
		return;
	}
}
// System.Void _Root.CodeBase.GamePlay.TailRender::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TailRender__ctor_mB5EE162E4A79076933B4903F5D7BA7524BDD6037 (TailRender_tEF5CE6E2641930BAEC0624DF292C9EE63297120C* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___x0, float ___y1, const RuntimeMethod* method) 
{
	{
		float L_0 = ___x0;
		__this->___x_0 = L_0;
		float L_1 = ___y1;
		__this->___y_1 = L_1;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Game_get_Service_m96C13F81CAEAEA5FBA2CA90A7FD61971BA9D3DC1_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public static IInputService Service => _inputService;
		RuntimeObject* L_0 = ((Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_StaticFields*)il2cpp_codegen_static_fields_for(Game_t44138E380413E01B330D8C2AE2F5D0B58E0CD40E_il2cpp_TypeInfo_var))->____inputService_0;
		return L_0;
	}
}
