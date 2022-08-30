	.file	"typemaps.x86_64.s"

/* map_module_count: START */
	.section	.rodata.map_module_count,"a",@progbits
	.type	map_module_count, @object
	.p2align	2
	.global	map_module_count
map_module_count:
	.size	map_module_count, 4
	.long	15
/* map_module_count: END */

/* java_type_count: START */
	.section	.rodata.java_type_count,"a",@progbits
	.type	java_type_count, @object
	.p2align	2
	.global	java_type_count
java_type_count:
	.size	java_type_count, 4
	.long	377
/* java_type_count: END */

	.include	"typemaps.shared.inc"
	.include	"typemaps.x86_64-managed.inc"

/* Managed to Java map: START */
	.section	.data.rel.map_modules,"aw",@progbits
	.type	map_modules, @object
	.p2align	4
	.global	map_modules
map_modules:
	/* module_uuid: 8c81d503-ba08-4e9e-955b-8e3f46e6259d */
	.byte	0x03, 0xd5, 0x81, 0x8c, 0x08, 0xba, 0x9e, 0x4e, 0x95, 0x5b, 0x8e, 0x3f, 0x46, 0xe6, 0x25, 0x9d
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	1
	/* map */
	.quad	module0_managed_to_java
	/* duplicate_map */
	.quad	module0_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.DrawerLayout */
	.quad	.L.map_aname.0
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 1d973306-500c-45bc-a7d7-f86648aa18d4 */
	.byte	0x06, 0x33, 0x97, 0x1d, 0x0c, 0x50, 0xbc, 0x45, 0xa7, 0xd7, 0xf8, 0x66, 0x48, 0xaa, 0x18, 0xd4
	/* entry_count */
	.long	4
	/* duplicate_count */
	.long	3
	/* map */
	.quad	module1_managed_to_java
	/* duplicate_map */
	.quad	module1_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.Common */
	.quad	.L.map_aname.1
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 09912f0b-f7d6-4618-8bb1-e6fe36c80d94 */
	.byte	0x0b, 0x2f, 0x91, 0x09, 0xd6, 0xf7, 0x18, 0x46, 0x8b, 0xb1, 0xe6, 0xfe, 0x36, 0xc8, 0x0d, 0x94
	/* entry_count */
	.long	25
	/* duplicate_count */
	.long	14
	/* map */
	.quad	module2_managed_to_java
	/* duplicate_map */
	.quad	module2_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Core */
	.quad	.L.map_aname.2
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: c76ff11b-7138-4abb-8c41-f6ce0b2c9f68 */
	.byte	0x1b, 0xf1, 0x6f, 0xc7, 0x38, 0x71, 0xbb, 0x4a, 0x8c, 0x41, 0xf6, 0xce, 0x0b, 0x2c, 0x9f, 0x68
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	2
	/* map */
	.quad	module3_managed_to_java
	/* duplicate_map */
	.quad	module3_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.SavedState */
	.quad	.L.map_aname.3
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 5c54601e-f0aa-46fe-891d-53d9d9c656b3 */
	.byte	0x1e, 0x60, 0x54, 0x5c, 0xaa, 0xf0, 0xfe, 0x46, 0x89, 0x1d, 0x53, 0xd9, 0xd9, 0xc6, 0x56, 0xb3
	/* entry_count */
	.long	265
	/* duplicate_count */
	.long	142
	/* map */
	.quad	module4_managed_to_java
	/* duplicate_map */
	.quad	module4_managed_to_java_duplicates
	/* assembly_name: Mono.Android */
	.quad	.L.map_aname.4
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 6af61659-5025-49b3-9422-56a118315201 */
	.byte	0x59, 0x16, 0xf6, 0x6a, 0x25, 0x50, 0xb3, 0x49, 0x94, 0x22, 0x56, 0xa1, 0x18, 0x31, 0x52, 0x01
	/* entry_count */
	.long	10
	/* duplicate_count */
	.long	5
	/* map */
	.quad	module5_managed_to_java
	/* duplicate_map */
	.quad	module5_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Fragment */
	.quad	.L.map_aname.5
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: d2b01d5a-b81d-4f62-80e2-c362d81d9cd9 */
	.byte	0x5a, 0x1d, 0xb0, 0xd2, 0x1d, 0xb8, 0x62, 0x4f, 0x80, 0xe2, 0xc3, 0x62, 0xd8, 0x1d, 0x9c, 0xd9
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module6_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.Essentials */
	.quad	.L.map_aname.6
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 39474576-1024-4319-8815-86282e2971d8 */
	.byte	0x76, 0x45, 0x47, 0x39, 0x24, 0x10, 0x19, 0x43, 0x88, 0x15, 0x86, 0x28, 0x2e, 0x29, 0x71, 0xd8
	/* entry_count */
	.long	5
	/* duplicate_count */
	.long	4
	/* map */
	.quad	module7_managed_to_java
	/* duplicate_map */
	.quad	module7_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Loader */
	.quad	.L.map_aname.7
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: b034fa80-29bd-4559-8354-26a743f74253 */
	.byte	0x80, 0xfa, 0x34, 0xb0, 0xbd, 0x29, 0x59, 0x45, 0x83, 0x54, 0x26, 0xa7, 0x43, 0xf7, 0x42, 0x53
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module8_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.AndroidX.Activity */
	.quad	.L.map_aname.8
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 720fb389-a5c3-4d3b-8154-0f964f01df1e */
	.byte	0x89, 0xb3, 0x0f, 0x72, 0xc3, 0xa5, 0x3b, 0x4d, 0x81, 0x54, 0x0f, 0x96, 0x4f, 0x01, 0xdf, 0x1e
	/* entry_count */
	.long	21
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module9_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: AplikasiMoora */
	.quad	.L.map_aname.9
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 9ac1089a-eef9-4b98-b18e-ecbbdf857cee */
	.byte	0x9a, 0x08, 0xc1, 0x9a, 0xf9, 0xee, 0x98, 0x4b, 0xb1, 0x8e, 0xec, 0xbb, 0xdf, 0x85, 0x7c, 0xee
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	2
	/* map */
	.quad	module10_managed_to_java
	/* duplicate_map */
	.quad	module10_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.LiveData.Core */
	.quad	.L.map_aname.10
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 5d71c2a3-54dd-4890-8b03-0874d6551eff */
	.byte	0xa3, 0xc2, 0x71, 0x5d, 0xdd, 0x54, 0x90, 0x48, 0x8b, 0x03, 0x08, 0x74, 0xd6, 0x55, 0x1e, 0xff
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	1
	/* map */
	.quad	module11_managed_to_java
	/* duplicate_map */
	.quad	module11_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.CustomView */
	.quad	.L.map_aname.11
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 379d77c4-cf8a-4445-860b-68af3453eb4e */
	.byte	0xc4, 0x77, 0x9d, 0x37, 0x8a, 0xcf, 0x45, 0x44, 0x86, 0x0b, 0x68, 0xaf, 0x34, 0x53, 0xeb, 0x4e
	/* entry_count */
	.long	30
	/* duplicate_count */
	.long	17
	/* map */
	.quad	module12_managed_to_java
	/* duplicate_map */
	.quad	module12_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.AppCompat */
	.quad	.L.map_aname.12
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 22ab85d9-c40c-4739-b6fe-c7ac6cfd022e */
	.byte	0xd9, 0x85, 0xab, 0x22, 0x0c, 0xc4, 0x39, 0x47, 0xb6, 0xfe, 0xc7, 0xac, 0x6c, 0xfd, 0x02, 0x2e
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	1
	/* map */
	.quad	module13_managed_to_java
	/* duplicate_map */
	.quad	module13_managed_to_java_duplicates
	/* assembly_name: Xamarin.Google.Guava.ListenableFuture */
	.quad	.L.map_aname.13
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 965ee4e5-b5e4-4fc6-9599-a10985f821f3 */
	.byte	0xe5, 0xe4, 0x5e, 0x96, 0xe4, 0xb5, 0xc6, 0x4f, 0x95, 0x99, 0xa1, 0x09, 0x85, 0xf8, 0x21, 0xf3
	/* entry_count */
	.long	5
	/* duplicate_count */
	.long	3
	/* map */
	.quad	module14_managed_to_java
	/* duplicate_map */
	.quad	module14_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.ViewModel */
	.quad	.L.map_aname.14
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	.size	map_modules, 1080
/* Managed to Java map: END */

/* Java to managed map: START */
	.section	.rodata.map_java,"a",@progbits
	.type	map_java, @object
	.p2align	4
	.global	map_java
map_java:
	/* #0 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554790
	/* java_name */
	.ascii	"android/animation/Animator"
	.zero	55
	.zero	9

	/* #1 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorListener"
	.zero	38
	.zero	9

	/* #2 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorPauseListener"
	.zero	33
	.zero	9

	/* #3 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554796
	/* java_name */
	.ascii	"android/animation/AnimatorListenerAdapter"
	.zero	40
	.zero	9

	/* #4 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/animation/TimeInterpolator"
	.zero	47
	.zero	9

	/* #5 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554801
	/* java_name */
	.ascii	"android/app/Activity"
	.zero	61
	.zero	9

	/* #6 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554802
	/* java_name */
	.ascii	"android/app/Application"
	.zero	58
	.zero	9

	/* #7 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/app/Application$ActivityLifecycleCallbacks"
	.zero	31
	.zero	9

	/* #8 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554805
	/* java_name */
	.ascii	"android/app/Dialog"
	.zero	63
	.zero	9

	/* #9 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554809
	/* java_name */
	.ascii	"android/app/PendingIntent"
	.zero	56
	.zero	9

	/* #10 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/content/ComponentCallbacks"
	.zero	47
	.zero	9

	/* #11 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/content/ComponentCallbacks2"
	.zero	46
	.zero	9

	/* #12 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554813
	/* java_name */
	.ascii	"android/content/ComponentName"
	.zero	52
	.zero	9

	/* #13 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554810
	/* java_name */
	.ascii	"android/content/Context"
	.zero	58
	.zero	9

	/* #14 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554815
	/* java_name */
	.ascii	"android/content/ContextWrapper"
	.zero	51
	.zero	9

	/* #15 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/content/DialogInterface"
	.zero	50
	.zero	9

	/* #16 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/content/DialogInterface$OnClickListener"
	.zero	34
	.zero	9

	/* #17 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554811
	/* java_name */
	.ascii	"android/content/Intent"
	.zero	59
	.zero	9

	/* #18 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554825
	/* java_name */
	.ascii	"android/content/IntentSender"
	.zero	53
	.zero	9

	/* #19 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/content/SharedPreferences"
	.zero	48
	.zero	9

	/* #20 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/content/SharedPreferences$Editor"
	.zero	41
	.zero	9

	/* #21 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/content/SharedPreferences$OnSharedPreferenceChangeListener"
	.zero	15
	.zero	9

	/* #22 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554833
	/* java_name */
	.ascii	"android/content/pm/PackageInfo"
	.zero	51
	.zero	9

	/* #23 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554835
	/* java_name */
	.ascii	"android/content/pm/PackageManager"
	.zero	48
	.zero	9

	/* #24 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554838
	/* java_name */
	.ascii	"android/content/res/ColorStateList"
	.zero	47
	.zero	9

	/* #25 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554839
	/* java_name */
	.ascii	"android/content/res/Configuration"
	.zero	48
	.zero	9

	/* #26 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554840
	/* java_name */
	.ascii	"android/content/res/Resources"
	.zero	52
	.zero	9

	/* #27 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554841
	/* java_name */
	.ascii	"android/content/res/Resources$Theme"
	.zero	46
	.zero	9

	/* #28 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554590
	/* java_name */
	.ascii	"android/database/DataSetObserver"
	.zero	49
	.zero	9

	/* #29 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554777
	/* java_name */
	.ascii	"android/graphics/BlendMode"
	.zero	55
	.zero	9

	/* #30 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554776
	/* java_name */
	.ascii	"android/graphics/Canvas"
	.zero	58
	.zero	9

	/* #31 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554778
	/* java_name */
	.ascii	"android/graphics/ColorFilter"
	.zero	53
	.zero	9

	/* #32 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554779
	/* java_name */
	.ascii	"android/graphics/Matrix"
	.zero	58
	.zero	9

	/* #33 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554780
	/* java_name */
	.ascii	"android/graphics/Paint"
	.zero	59
	.zero	9

	/* #34 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554781
	/* java_name */
	.ascii	"android/graphics/Point"
	.zero	59
	.zero	9

	/* #35 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554782
	/* java_name */
	.ascii	"android/graphics/PorterDuff"
	.zero	54
	.zero	9

	/* #36 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554783
	/* java_name */
	.ascii	"android/graphics/PorterDuff$Mode"
	.zero	49
	.zero	9

	/* #37 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554784
	/* java_name */
	.ascii	"android/graphics/Rect"
	.zero	60
	.zero	9

	/* #38 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554785
	/* java_name */
	.ascii	"android/graphics/RectF"
	.zero	59
	.zero	9

	/* #39 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554786
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable"
	.zero	47
	.zero	9

	/* #40 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable$Callback"
	.zero	38
	.zero	9

	/* #41 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554773
	/* java_name */
	.ascii	"android/net/Uri"
	.zero	66
	.zero	9

	/* #42 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554761
	/* java_name */
	.ascii	"android/os/BaseBundle"
	.zero	60
	.zero	9

	/* #43 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554762
	/* java_name */
	.ascii	"android/os/Build"
	.zero	65
	.zero	9

	/* #44 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554763
	/* java_name */
	.ascii	"android/os/Build$VERSION"
	.zero	57
	.zero	9

	/* #45 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554765
	/* java_name */
	.ascii	"android/os/Bundle"
	.zero	64
	.zero	9

	/* #46 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554760
	/* java_name */
	.ascii	"android/os/Handler"
	.zero	63
	.zero	9

	/* #47 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554770
	/* java_name */
	.ascii	"android/os/Looper"
	.zero	64
	.zero	9

	/* #48 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554771
	/* java_name */
	.ascii	"android/os/Parcel"
	.zero	64
	.zero	9

	/* #49 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/os/Parcelable"
	.zero	60
	.zero	9

	/* #50 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/os/Parcelable$Creator"
	.zero	52
	.zero	9

	/* #51 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554759
	/* java_name */
	.ascii	"android/preference/PreferenceManager"
	.zero	45
	.zero	9

	/* #52 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554887
	/* java_name */
	.ascii	"android/runtime/JavaProxyThrowable"
	.zero	47
	.zero	9

	/* #53 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/text/Editable"
	.zero	60
	.zero	9

	/* #54 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/text/GetChars"
	.zero	60
	.zero	9

	/* #55 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/text/InputFilter"
	.zero	57
	.zero	9

	/* #56 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/text/NoCopySpan"
	.zero	58
	.zero	9

	/* #57 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/text/Spannable"
	.zero	59
	.zero	9

	/* #58 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/text/Spanned"
	.zero	61
	.zero	9

	/* #59 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/text/TextWatcher"
	.zero	57
	.zero	9

	/* #60 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/util/AttributeSet"
	.zero	56
	.zero	9

	/* #61 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554733
	/* java_name */
	.ascii	"android/util/DisplayMetrics"
	.zero	54
	.zero	9

	/* #62 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554736
	/* java_name */
	.ascii	"android/util/SparseArray"
	.zero	57
	.zero	9

	/* #63 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554669
	/* java_name */
	.ascii	"android/view/ActionMode"
	.zero	58
	.zero	9

	/* #64 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/ActionMode$Callback"
	.zero	49
	.zero	9

	/* #65 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554674
	/* java_name */
	.ascii	"android/view/ActionProvider"
	.zero	54
	.zero	9

	/* #66 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/ContextMenu"
	.zero	57
	.zero	9

	/* #67 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/ContextMenu$ContextMenuInfo"
	.zero	41
	.zero	9

	/* #68 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554676
	/* java_name */
	.ascii	"android/view/ContextThemeWrapper"
	.zero	49
	.zero	9

	/* #69 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554677
	/* java_name */
	.ascii	"android/view/Display"
	.zero	61
	.zero	9

	/* #70 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554678
	/* java_name */
	.ascii	"android/view/DragEvent"
	.zero	59
	.zero	9

	/* #71 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554692
	/* java_name */
	.ascii	"android/view/InputEvent"
	.zero	58
	.zero	9

	/* #72 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554650
	/* java_name */
	.ascii	"android/view/KeyEvent"
	.zero	60
	.zero	9

	/* #73 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/KeyEvent$Callback"
	.zero	51
	.zero	9

	/* #74 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554703
	/* java_name */
	.ascii	"android/view/KeyboardShortcutGroup"
	.zero	47
	.zero	9

	/* #75 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554653
	/* java_name */
	.ascii	"android/view/LayoutInflater"
	.zero	54
	.zero	9

	/* #76 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory"
	.zero	46
	.zero	9

	/* #77 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory2"
	.zero	45
	.zero	9

	/* #78 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/Menu"
	.zero	64
	.zero	9

	/* #79 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554708
	/* java_name */
	.ascii	"android/view/MenuInflater"
	.zero	56
	.zero	9

	/* #80 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/MenuItem"
	.zero	60
	.zero	9

	/* #81 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/MenuItem$OnActionExpandListener"
	.zero	37
	.zero	9

	/* #82 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/MenuItem$OnMenuItemClickListener"
	.zero	36
	.zero	9

	/* #83 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554658
	/* java_name */
	.ascii	"android/view/MotionEvent"
	.zero	57
	.zero	9

	/* #84 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554711
	/* java_name */
	.ascii	"android/view/SearchEvent"
	.zero	57
	.zero	9

	/* #85 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/SubMenu"
	.zero	61
	.zero	9

	/* #86 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554642
	/* java_name */
	.ascii	"android/view/View"
	.zero	64
	.zero	9

	/* #87 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/View$OnClickListener"
	.zero	48
	.zero	9

	/* #88 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/View$OnCreateContextMenuListener"
	.zero	36
	.zero	9

	/* #89 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554715
	/* java_name */
	.ascii	"android/view/ViewGroup"
	.zero	59
	.zero	9

	/* #90 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554716
	/* java_name */
	.ascii	"android/view/ViewGroup$LayoutParams"
	.zero	46
	.zero	9

	/* #91 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554717
	/* java_name */
	.ascii	"android/view/ViewGroup$MarginLayoutParams"
	.zero	40
	.zero	9

	/* #92 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/ViewManager"
	.zero	57
	.zero	9

	/* #93 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/ViewParent"
	.zero	58
	.zero	9

	/* #94 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554719
	/* java_name */
	.ascii	"android/view/ViewPropertyAnimator"
	.zero	48
	.zero	9

	/* #95 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554659
	/* java_name */
	.ascii	"android/view/ViewTreeObserver"
	.zero	52
	.zero	9

	/* #96 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/ViewTreeObserver$OnGlobalLayoutListener"
	.zero	29
	.zero	9

	/* #97 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/ViewTreeObserver$OnPreDrawListener"
	.zero	34
	.zero	9

	/* #98 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/ViewTreeObserver$OnTouchModeChangeListener"
	.zero	26
	.zero	9

	/* #99 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554666
	/* java_name */
	.ascii	"android/view/Window"
	.zero	62
	.zero	9

	/* #100 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/Window$Callback"
	.zero	53
	.zero	9

	/* #101 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/WindowManager"
	.zero	55
	.zero	9

	/* #102 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554700
	/* java_name */
	.ascii	"android/view/WindowManager$LayoutParams"
	.zero	42
	.zero	9

	/* #103 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554721
	/* java_name */
	.ascii	"android/view/WindowMetrics"
	.zero	55
	.zero	9

	/* #104 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554726
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEvent"
	.zero	36
	.zero	9

	/* #105 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEventSource"
	.zero	30
	.zero	9

	/* #106 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554727
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityRecord"
	.zero	35
	.zero	9

	/* #107 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554722
	/* java_name */
	.ascii	"android/view/animation/Animation"
	.zero	49
	.zero	9

	/* #108 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/view/animation/Interpolator"
	.zero	46
	.zero	9

	/* #109 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554592
	/* java_name */
	.ascii	"android/widget/AbsListView"
	.zero	55
	.zero	9

	/* #110 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554612
	/* java_name */
	.ascii	"android/widget/AbsSpinner"
	.zero	56
	.zero	9

	/* #111 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/Adapter"
	.zero	59
	.zero	9

	/* #112 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554594
	/* java_name */
	.ascii	"android/widget/AdapterView"
	.zero	55
	.zero	9

	/* #113 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/AdapterView$OnItemClickListener"
	.zero	35
	.zero	9

	/* #114 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/AdapterView$OnItemSelectedListener"
	.zero	32
	.zero	9

	/* #115 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/ArrayAdapter"
	.zero	54
	.zero	9

	/* #116 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/BaseAdapter"
	.zero	55
	.zero	9

	/* #117 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554618
	/* java_name */
	.ascii	"android/widget/Button"
	.zero	60
	.zero	9

	/* #118 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554619
	/* java_name */
	.ascii	"android/widget/EditText"
	.zero	58
	.zero	9

	/* #119 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554620
	/* java_name */
	.ascii	"android/widget/Filter"
	.zero	60
	.zero	9

	/* #120 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/Filter$FilterListener"
	.zero	45
	.zero	9

	/* #121 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/Filterable"
	.zero	56
	.zero	9

	/* #122 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554624
	/* java_name */
	.ascii	"android/widget/FrameLayout"
	.zero	55
	.zero	9

	/* #123 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554625
	/* java_name */
	.ascii	"android/widget/HorizontalScrollView"
	.zero	46
	.zero	9

	/* #124 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554632
	/* java_name */
	.ascii	"android/widget/ImageView"
	.zero	57
	.zero	9

	/* #125 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554637
	/* java_name */
	.ascii	"android/widget/LinearLayout"
	.zero	54
	.zero	9

	/* #126 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/ListAdapter"
	.zero	55
	.zero	9

	/* #127 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554638
	/* java_name */
	.ascii	"android/widget/ListView"
	.zero	58
	.zero	9

	/* #128 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554639
	/* java_name */
	.ascii	"android/widget/Spinner"
	.zero	59
	.zero	9

	/* #129 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/SpinnerAdapter"
	.zero	52
	.zero	9

	/* #130 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554611
	/* java_name */
	.ascii	"android/widget/TextView"
	.zero	58
	.zero	9

	/* #131 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"android/widget/ThemedSpinnerAdapter"
	.zero	46
	.zero	9

	/* #132 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554640
	/* java_name */
	.ascii	"android/widget/Toast"
	.zero	61
	.zero	9

	/* #133 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554434
	/* java_name */
	.ascii	"androidx/activity/ComponentActivity"
	.zero	46
	.zero	9

	/* #134 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar"
	.zero	49
	.zero	9

	/* #135 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554475
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$LayoutParams"
	.zero	36
	.zero	9

	/* #136 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$OnMenuVisibilityListener"
	.zero	24
	.zero	9

	/* #137 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$OnNavigationListener"
	.zero	28
	.zero	9

	/* #138 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554482
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$Tab"
	.zero	45
	.zero	9

	/* #139 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$TabListener"
	.zero	37
	.zero	9

	/* #140 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554489
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle"
	.zero	37
	.zero	9

	/* #141 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle$Delegate"
	.zero	28
	.zero	9

	/* #142 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider"
	.zero	20
	.zero	9

	/* #143 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554494
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatActivity"
	.zero	41
	.zero	9

	/* #144 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatCallback"
	.zero	41
	.zero	9

	/* #145 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554495
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatDelegate"
	.zero	41
	.zero	9

	/* #146 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"androidx/appcompat/graphics/drawable/DrawerArrowDrawable"
	.zero	25
	.zero	9

	/* #147 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554512
	/* java_name */
	.ascii	"androidx/appcompat/view/ActionMode"
	.zero	47
	.zero	9

	/* #148 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/view/ActionMode$Callback"
	.zero	38
	.zero	9

	/* #149 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554516
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuBuilder"
	.zero	41
	.zero	9

	/* #150 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuBuilder$Callback"
	.zero	32
	.zero	9

	/* #151 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554525
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuItemImpl"
	.zero	40
	.zero	9

	/* #152 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuPresenter"
	.zero	39
	.zero	9

	/* #153 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuPresenter$Callback"
	.zero	30
	.zero	9

	/* #154 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuView"
	.zero	44
	.zero	9

	/* #155 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554526
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/SubMenuBuilder"
	.zero	38
	.zero	9

	/* #156 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/widget/DecorToolbar"
	.zero	43
	.zero	9

	/* #157 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554510
	/* java_name */
	.ascii	"androidx/appcompat/widget/ScrollingTabContainerView"
	.zero	30
	.zero	9

	/* #158 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554511
	/* java_name */
	.ascii	"androidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener"
	.zero	7
	.zero	9

	/* #159 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554499
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar"
	.zero	48
	.zero	9

	/* #160 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar$OnMenuItemClickListener"
	.zero	24
	.zero	9

	/* #161 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554500
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar_NavigationOnClickEventDispatcher"
	.zero	15
	.zero	9

	/* #162 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554494
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat"
	.zero	49
	.zero	9

	/* #163 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback"
	.zero	14
	.zero	9

	/* #164 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$PermissionCompatDelegate"
	.zero	24
	.zero	9

	/* #165 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator"
	.zero	10
	.zero	9

	/* #166 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554501
	/* java_name */
	.ascii	"androidx/core/app/ComponentActivity"
	.zero	46
	.zero	9

	/* #167 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554502
	/* java_name */
	.ascii	"androidx/core/app/ComponentActivity$ExtraData"
	.zero	36
	.zero	9

	/* #168 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554503
	/* java_name */
	.ascii	"androidx/core/app/SharedElementCallback"
	.zero	42
	.zero	9

	/* #169 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener"
	.zero	12
	.zero	9

	/* #170 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554507
	/* java_name */
	.ascii	"androidx/core/app/TaskStackBuilder"
	.zero	47
	.zero	9

	/* #171 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/app/TaskStackBuilder$SupportParentable"
	.zero	29
	.zero	9

	/* #172 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554492
	/* java_name */
	.ascii	"androidx/core/content/ContextCompat"
	.zero	46
	.zero	9

	/* #173 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554493
	/* java_name */
	.ascii	"androidx/core/content/pm/PackageInfoCompat"
	.zero	39
	.zero	9

	/* #174 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/internal/view/SupportMenu"
	.zero	42
	.zero	9

	/* #175 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/internal/view/SupportMenuItem"
	.zero	38
	.zero	9

	/* #176 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554465
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider"
	.zero	48
	.zero	9

	/* #177 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider$SubUiVisibilityListener"
	.zero	24
	.zero	9

	/* #178 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider$VisibilityListener"
	.zero	29
	.zero	9

	/* #179 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554479
	/* java_name */
	.ascii	"androidx/core/view/DragAndDropPermissionsCompat"
	.zero	34
	.zero	9

	/* #180 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554484
	/* java_name */
	.ascii	"androidx/core/view/KeyEventDispatcher"
	.zero	44
	.zero	9

	/* #181 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/view/KeyEventDispatcher$Component"
	.zero	34
	.zero	9

	/* #182 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554487
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorCompat"
	.zero	36
	.zero	9

	/* #183 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorListener"
	.zero	34
	.zero	9

	/* #184 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorUpdateListener"
	.zero	28
	.zero	9

	/* #185 */
	/* module_index */
	.long	11
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/customview/widget/Openable"
	.zero	46
	.zero	9

	/* #186 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554454
	/* java_name */
	.ascii	"androidx/drawerlayout/widget/DrawerLayout"
	.zero	40
	.zero	9

	/* #187 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/drawerlayout/widget/DrawerLayout$DrawerListener"
	.zero	25
	.zero	9

	/* #188 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554468
	/* java_name */
	.ascii	"androidx/fragment/app/Fragment"
	.zero	51
	.zero	9

	/* #189 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"androidx/fragment/app/Fragment$SavedState"
	.zero	40
	.zero	9

	/* #190 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554467
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentActivity"
	.zero	43
	.zero	9

	/* #191 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554470
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentFactory"
	.zero	44
	.zero	9

	/* #192 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager"
	.zero	44
	.zero	9

	/* #193 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$BackStackEntry"
	.zero	29
	.zero	9

	/* #194 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks"
	.zero	17
	.zero	9

	/* #195 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$OnBackStackChangedListener"
	.zero	17
	.zero	9

	/* #196 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554482
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentTransaction"
	.zero	40
	.zero	9

	/* #197 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/lifecycle/HasDefaultViewModelProviderFactory"
	.zero	28
	.zero	9

	/* #198 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/lifecycle/Lifecycle"
	.zero	53
	.zero	9

	/* #199 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/lifecycle/Lifecycle$State"
	.zero	47
	.zero	9

	/* #200 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/lifecycle/LifecycleObserver"
	.zero	45
	.zero	9

	/* #201 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/lifecycle/LifecycleOwner"
	.zero	48
	.zero	9

	/* #202 */
	/* module_index */
	.long	10
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"androidx/lifecycle/LiveData"
	.zero	54
	.zero	9

	/* #203 */
	/* module_index */
	.long	10
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/lifecycle/Observer"
	.zero	54
	.zero	9

	/* #204 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelProvider"
	.zero	45
	.zero	9

	/* #205 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelProvider$Factory"
	.zero	37
	.zero	9

	/* #206 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelStore"
	.zero	48
	.zero	9

	/* #207 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelStoreOwner"
	.zero	43
	.zero	9

	/* #208 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"androidx/loader/app/LoaderManager"
	.zero	48
	.zero	9

	/* #209 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/loader/app/LoaderManager$LoaderCallbacks"
	.zero	32
	.zero	9

	/* #210 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"androidx/loader/content/Loader"
	.zero	51
	.zero	9

	/* #211 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/loader/content/Loader$OnLoadCanceledListener"
	.zero	28
	.zero	9

	/* #212 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/loader/content/Loader$OnLoadCompleteListener"
	.zero	28
	.zero	9

	/* #213 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistry"
	.zero	43
	.zero	9

	/* #214 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistry$SavedStateProvider"
	.zero	24
	.zero	9

	/* #215 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistryOwner"
	.zero	38
	.zero	9

	/* #216 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"com/google/common/util/concurrent/ListenableFuture"
	.zero	31
	.zero	9

	/* #217 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554448
	/* java_name */
	.ascii	"crc64a0e0a82d0db9a07d/ActivityLifecycleContextListener"
	.zero	27
	.zero	9

	/* #218 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554434
	/* java_name */
	.ascii	"crc64bb8866cb4dc8a251/MainActivity"
	.zero	47
	.zero	9

	/* #219 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"crc64dc8f74d25ff10f69/AlternatifAdapter"
	.zero	42
	.zero	9

	/* #220 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"crc64dc8f74d25ff10f69/KriteriaAdapter"
	.zero	44
	.zero	9

	/* #221 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"crc64dc8f74d25ff10f69/NormalisasiAdapter"
	.zero	41
	.zero	9

	/* #222 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"crc64dc8f74d25ff10f69/OptimasiAdapter"
	.zero	44
	.zero	9

	/* #223 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"crc64dc8f74d25ff10f69/PerankinganAdapter"
	.zero	41
	.zero	9

	/* #224 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"crc64dc8f74d25ff10f69/SpkAdapter"
	.zero	49
	.zero	9

	/* #225 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554465
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/AlternatifActivity"
	.zero	41
	.zero	9

	/* #226 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/AlternatifAddActivity"
	.zero	38
	.zero	9

	/* #227 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554468
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/AlternatifUpdateActivity"
	.zero	35
	.zero	9

	/* #228 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554464
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/HasilActivity"
	.zero	46
	.zero	9

	/* #229 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554467
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/HistoryActivity"
	.zero	44
	.zero	9

	/* #230 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554466
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/KriteriaActivity"
	.zero	43
	.zero	9

	/* #231 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/KriteriaAddActivity"
	.zero	40
	.zero	9

	/* #232 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554470
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/KriteriaUpdateActivity"
	.zero	37
	.zero	9

	/* #233 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/LoginActivity"
	.zero	46
	.zero	9

	/* #234 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554472
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/ProsesActivity"
	.zero	45
	.zero	9

	/* #235 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/ProsesAdd_Activity"
	.zero	41
	.zero	9

	/* #236 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/ProsesUpdate_Activity"
	.zero	38
	.zero	9

	/* #237 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554475
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/RegisterActivity"
	.zero	43
	.zero	9

	/* #238 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554463
	/* java_name */
	.ascii	"crc64f5a02a4d80b0f816/SpkActivity"
	.zero	48
	.zero	9

	/* #239 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/io/Closeable"
	.zero	64
	.zero	9

	/* #240 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555053
	/* java_name */
	.ascii	"java/io/File"
	.zero	69
	.zero	9

	/* #241 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555054
	/* java_name */
	.ascii	"java/io/FileDescriptor"
	.zero	59
	.zero	9

	/* #242 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555055
	/* java_name */
	.ascii	"java/io/FileInputStream"
	.zero	58
	.zero	9

	/* #243 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/io/Flushable"
	.zero	64
	.zero	9

	/* #244 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555063
	/* java_name */
	.ascii	"java/io/IOException"
	.zero	62
	.zero	9

	/* #245 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555060
	/* java_name */
	.ascii	"java/io/InputStream"
	.zero	62
	.zero	9

	/* #246 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555062
	/* java_name */
	.ascii	"java/io/InterruptedIOException"
	.zero	51
	.zero	9

	/* #247 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555066
	/* java_name */
	.ascii	"java/io/OutputStream"
	.zero	61
	.zero	9

	/* #248 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555068
	/* java_name */
	.ascii	"java/io/PrintWriter"
	.zero	62
	.zero	9

	/* #249 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/io/Serializable"
	.zero	61
	.zero	9

	/* #250 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555069
	/* java_name */
	.ascii	"java/io/StringWriter"
	.zero	61
	.zero	9

	/* #251 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555070
	/* java_name */
	.ascii	"java/io/Writer"
	.zero	67
	.zero	9

	/* #252 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/Appendable"
	.zero	61
	.zero	9

	/* #253 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554995
	/* java_name */
	.ascii	"java/lang/Boolean"
	.zero	64
	.zero	9

	/* #254 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554996
	/* java_name */
	.ascii	"java/lang/Byte"
	.zero	67
	.zero	9

	/* #255 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/CharSequence"
	.zero	59
	.zero	9

	/* #256 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554997
	/* java_name */
	.ascii	"java/lang/Character"
	.zero	62
	.zero	9

	/* #257 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554998
	/* java_name */
	.ascii	"java/lang/Class"
	.zero	66
	.zero	9

	/* #258 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555014
	/* java_name */
	.ascii	"java/lang/ClassCastException"
	.zero	53
	.zero	9

	/* #259 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555015
	/* java_name */
	.ascii	"java/lang/ClassLoader"
	.zero	60
	.zero	9

	/* #260 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554999
	/* java_name */
	.ascii	"java/lang/ClassNotFoundException"
	.zero	49
	.zero	9

	/* #261 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/Cloneable"
	.zero	62
	.zero	9

	/* #262 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/Comparable"
	.zero	61
	.zero	9

	/* #263 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555000
	/* java_name */
	.ascii	"java/lang/Double"
	.zero	65
	.zero	9

	/* #264 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555017
	/* java_name */
	.ascii	"java/lang/Enum"
	.zero	67
	.zero	9

	/* #265 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555019
	/* java_name */
	.ascii	"java/lang/Error"
	.zero	66
	.zero	9

	/* #266 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555001
	/* java_name */
	.ascii	"java/lang/Exception"
	.zero	62
	.zero	9

	/* #267 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555002
	/* java_name */
	.ascii	"java/lang/Float"
	.zero	66
	.zero	9

	/* #268 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555030
	/* java_name */
	.ascii	"java/lang/IllegalArgumentException"
	.zero	47
	.zero	9

	/* #269 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555031
	/* java_name */
	.ascii	"java/lang/IllegalStateException"
	.zero	50
	.zero	9

	/* #270 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555032
	/* java_name */
	.ascii	"java/lang/IndexOutOfBoundsException"
	.zero	46
	.zero	9

	/* #271 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555004
	/* java_name */
	.ascii	"java/lang/Integer"
	.zero	64
	.zero	9

	/* #272 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/Iterable"
	.zero	63
	.zero	9

	/* #273 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555035
	/* java_name */
	.ascii	"java/lang/LinkageError"
	.zero	59
	.zero	9

	/* #274 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555005
	/* java_name */
	.ascii	"java/lang/Long"
	.zero	67
	.zero	9

	/* #275 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555036
	/* java_name */
	.ascii	"java/lang/NoClassDefFoundError"
	.zero	51
	.zero	9

	/* #276 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555037
	/* java_name */
	.ascii	"java/lang/NullPointerException"
	.zero	51
	.zero	9

	/* #277 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555038
	/* java_name */
	.ascii	"java/lang/Number"
	.zero	65
	.zero	9

	/* #278 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555006
	/* java_name */
	.ascii	"java/lang/Object"
	.zero	65
	.zero	9

	/* #279 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555040
	/* java_name */
	.ascii	"java/lang/ReflectiveOperationException"
	.zero	43
	.zero	9

	/* #280 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/Runnable"
	.zero	63
	.zero	9

	/* #281 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555007
	/* java_name */
	.ascii	"java/lang/RuntimeException"
	.zero	55
	.zero	9

	/* #282 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555041
	/* java_name */
	.ascii	"java/lang/SecurityException"
	.zero	54
	.zero	9

	/* #283 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555008
	/* java_name */
	.ascii	"java/lang/Short"
	.zero	66
	.zero	9

	/* #284 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555009
	/* java_name */
	.ascii	"java/lang/String"
	.zero	65
	.zero	9

	/* #285 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555011
	/* java_name */
	.ascii	"java/lang/Thread"
	.zero	65
	.zero	9

	/* #286 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555013
	/* java_name */
	.ascii	"java/lang/Throwable"
	.zero	62
	.zero	9

	/* #287 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555042
	/* java_name */
	.ascii	"java/lang/UnsupportedOperationException"
	.zero	42
	.zero	9

	/* #288 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/annotation/Annotation"
	.zero	50
	.zero	9

	/* #289 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/reflect/AnnotatedElement"
	.zero	47
	.zero	9

	/* #290 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/reflect/GenericDeclaration"
	.zero	45
	.zero	9

	/* #291 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/reflect/Type"
	.zero	59
	.zero	9

	/* #292 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/lang/reflect/TypeVariable"
	.zero	51
	.zero	9

	/* #293 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554912
	/* java_name */
	.ascii	"java/net/ConnectException"
	.zero	56
	.zero	9

	/* #294 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554914
	/* java_name */
	.ascii	"java/net/HttpURLConnection"
	.zero	55
	.zero	9

	/* #295 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554916
	/* java_name */
	.ascii	"java/net/InetSocketAddress"
	.zero	55
	.zero	9

	/* #296 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554917
	/* java_name */
	.ascii	"java/net/ProtocolException"
	.zero	55
	.zero	9

	/* #297 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554918
	/* java_name */
	.ascii	"java/net/Proxy"
	.zero	67
	.zero	9

	/* #298 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554919
	/* java_name */
	.ascii	"java/net/Proxy$Type"
	.zero	62
	.zero	9

	/* #299 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554920
	/* java_name */
	.ascii	"java/net/ProxySelector"
	.zero	59
	.zero	9

	/* #300 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554922
	/* java_name */
	.ascii	"java/net/SocketAddress"
	.zero	59
	.zero	9

	/* #301 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554924
	/* java_name */
	.ascii	"java/net/SocketException"
	.zero	57
	.zero	9

	/* #302 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554925
	/* java_name */
	.ascii	"java/net/SocketTimeoutException"
	.zero	50
	.zero	9

	/* #303 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554927
	/* java_name */
	.ascii	"java/net/URI"
	.zero	69
	.zero	9

	/* #304 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554928
	/* java_name */
	.ascii	"java/net/URL"
	.zero	69
	.zero	9

	/* #305 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554929
	/* java_name */
	.ascii	"java/net/URLConnection"
	.zero	59
	.zero	9

	/* #306 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554926
	/* java_name */
	.ascii	"java/net/UnknownServiceException"
	.zero	49
	.zero	9

	/* #307 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554971
	/* java_name */
	.ascii	"java/nio/Buffer"
	.zero	66
	.zero	9

	/* #308 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554973
	/* java_name */
	.ascii	"java/nio/ByteBuffer"
	.zero	62
	.zero	9

	/* #309 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/nio/channels/ByteChannel"
	.zero	52
	.zero	9

	/* #310 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/nio/channels/Channel"
	.zero	56
	.zero	9

	/* #311 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554975
	/* java_name */
	.ascii	"java/nio/channels/FileChannel"
	.zero	52
	.zero	9

	/* #312 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/nio/channels/GatheringByteChannel"
	.zero	43
	.zero	9

	/* #313 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/nio/channels/InterruptibleChannel"
	.zero	43
	.zero	9

	/* #314 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/nio/channels/ReadableByteChannel"
	.zero	44
	.zero	9

	/* #315 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/nio/channels/ScatteringByteChannel"
	.zero	42
	.zero	9

	/* #316 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/nio/channels/SeekableByteChannel"
	.zero	44
	.zero	9

	/* #317 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/nio/channels/WritableByteChannel"
	.zero	44
	.zero	9

	/* #318 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554993
	/* java_name */
	.ascii	"java/nio/channels/spi/AbstractInterruptibleChannel"
	.zero	31
	.zero	9

	/* #319 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554958
	/* java_name */
	.ascii	"java/security/KeyStore"
	.zero	59
	.zero	9

	/* #320 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/security/KeyStore$LoadStoreParameter"
	.zero	40
	.zero	9

	/* #321 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/security/KeyStore$ProtectionParameter"
	.zero	39
	.zero	9

	/* #322 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/security/Principal"
	.zero	58
	.zero	9

	/* #323 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554963
	/* java_name */
	.ascii	"java/security/SecureRandom"
	.zero	55
	.zero	9

	/* #324 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554964
	/* java_name */
	.ascii	"java/security/cert/Certificate"
	.zero	51
	.zero	9

	/* #325 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554966
	/* java_name */
	.ascii	"java/security/cert/CertificateFactory"
	.zero	44
	.zero	9

	/* #326 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554969
	/* java_name */
	.ascii	"java/security/cert/X509Certificate"
	.zero	47
	.zero	9

	/* #327 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/security/cert/X509Extension"
	.zero	49
	.zero	9

	/* #328 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554879
	/* java_name */
	.ascii	"java/util/ArrayList"
	.zero	62
	.zero	9

	/* #329 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554868
	/* java_name */
	.ascii	"java/util/Collection"
	.zero	61
	.zero	9

	/* #330 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/Comparator"
	.zero	61
	.zero	9

	/* #331 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/Enumeration"
	.zero	60
	.zero	9

	/* #332 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554870
	/* java_name */
	.ascii	"java/util/HashMap"
	.zero	64
	.zero	9

	/* #333 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554888
	/* java_name */
	.ascii	"java/util/HashSet"
	.zero	64
	.zero	9

	/* #334 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/Iterator"
	.zero	63
	.zero	9

	/* #335 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554939
	/* java_name */
	.ascii	"java/util/Random"
	.zero	65
	.zero	9

	/* #336 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/Spliterator"
	.zero	60
	.zero	9

	/* #337 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/concurrent/Executor"
	.zero	52
	.zero	9

	/* #338 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/concurrent/Future"
	.zero	54
	.zero	9

	/* #339 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554955
	/* java_name */
	.ascii	"java/util/concurrent/TimeUnit"
	.zero	52
	.zero	9

	/* #340 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/function/Consumer"
	.zero	54
	.zero	9

	/* #341 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/function/Function"
	.zero	54
	.zero	9

	/* #342 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/function/ToDoubleFunction"
	.zero	46
	.zero	9

	/* #343 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/function/ToIntFunction"
	.zero	49
	.zero	9

	/* #344 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"java/util/function/ToLongFunction"
	.zero	48
	.zero	9

	/* #345 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554561
	/* java_name */
	.ascii	"javax/net/SocketFactory"
	.zero	58
	.zero	9

	/* #346 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"javax/net/ssl/HostnameVerifier"
	.zero	51
	.zero	9

	/* #347 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554563
	/* java_name */
	.ascii	"javax/net/ssl/HttpsURLConnection"
	.zero	49
	.zero	9

	/* #348 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"javax/net/ssl/KeyManager"
	.zero	57
	.zero	9

	/* #349 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554577
	/* java_name */
	.ascii	"javax/net/ssl/KeyManagerFactory"
	.zero	50
	.zero	9

	/* #350 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554578
	/* java_name */
	.ascii	"javax/net/ssl/SSLContext"
	.zero	57
	.zero	9

	/* #351 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"javax/net/ssl/SSLSession"
	.zero	57
	.zero	9

	/* #352 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"javax/net/ssl/SSLSessionContext"
	.zero	50
	.zero	9

	/* #353 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554579
	/* java_name */
	.ascii	"javax/net/ssl/SSLSocketFactory"
	.zero	51
	.zero	9

	/* #354 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"javax/net/ssl/TrustManager"
	.zero	55
	.zero	9

	/* #355 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554581
	/* java_name */
	.ascii	"javax/net/ssl/TrustManagerFactory"
	.zero	48
	.zero	9

	/* #356 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"javax/net/ssl/X509TrustManager"
	.zero	51
	.zero	9

	/* #357 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554560
	/* java_name */
	.ascii	"javax/security/auth/Subject"
	.zero	54
	.zero	9

	/* #358 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554556
	/* java_name */
	.ascii	"javax/security/cert/Certificate"
	.zero	50
	.zero	9

	/* #359 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554558
	/* java_name */
	.ascii	"javax/security/cert/X509Certificate"
	.zero	46
	.zero	9

	/* #360 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555093
	/* java_name */
	.ascii	"mono/android/TypeManager"
	.zero	57
	.zero	9

	/* #361 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554864
	/* java_name */
	.ascii	"mono/android/runtime/InputStreamAdapter"
	.zero	42
	.zero	9

	/* #362 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"mono/android/runtime/JavaArray"
	.zero	51
	.zero	9

	/* #363 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554885
	/* java_name */
	.ascii	"mono/android/runtime/JavaObject"
	.zero	50
	.zero	9

	/* #364 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554903
	/* java_name */
	.ascii	"mono/android/runtime/OutputStreamAdapter"
	.zero	41
	.zero	9

	/* #365 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554739
	/* java_name */
	.ascii	"mono/android/text/TextWatcherImplementor"
	.zero	41
	.zero	9

	/* #366 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554645
	/* java_name */
	.ascii	"mono/android/view/View_OnClickListenerImplementor"
	.zero	32
	.zero	9

	/* #367 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554598
	/* java_name */
	.ascii	"mono/android/widget/AdapterView_OnItemClickListenerImplementor"
	.zero	19
	.zero	9

	/* #368 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554603
	/* java_name */
	.ascii	"mono/android/widget/AdapterView_OnItemSelectedListenerImplementor"
	.zero	16
	.zero	9

	/* #369 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554479
	/* java_name */
	.ascii	"mono/androidx/appcompat/app/ActionBar_OnMenuVisibilityListenerImplementor"
	.zero	8
	.zero	9

	/* #370 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554505
	/* java_name */
	.ascii	"mono/androidx/appcompat/widget/Toolbar_OnMenuItemClickListenerImplementor"
	.zero	8
	.zero	9

	/* #371 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"mono/androidx/core/view/ActionProvider_SubUiVisibilityListenerImplementor"
	.zero	8
	.zero	9

	/* #372 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"mono/androidx/core/view/ActionProvider_VisibilityListenerImplementor"
	.zero	13
	.zero	9

	/* #373 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554461
	/* java_name */
	.ascii	"mono/androidx/drawerlayout/widget/DrawerLayout_DrawerListenerImplementor"
	.zero	9
	.zero	9

	/* #374 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554478
	/* java_name */
	.ascii	"mono/androidx/fragment/app/FragmentManager_OnBackStackChangedListenerImplementor"
	.zero	1
	.zero	9

	/* #375 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33555012
	/* java_name */
	.ascii	"mono/java/lang/RunnableImplementor"
	.zero	47
	.zero	9

	/* #376 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554555
	/* java_name */
	.ascii	"xamarin/android/net/OldAndroidSSLSocketFactory"
	.zero	35
	.zero	9

	.size	map_java, 36946
/* Java to managed map: END */


/* java_name_width: START */
	.section	.rodata.java_name_width,"a",@progbits
	.type	java_name_width, @object
	.p2align	2
	.global	java_name_width
java_name_width:
	.size	java_name_width, 4
	.long	90
/* java_name_width: END */
