package crc64f5a02a4d80b0f816;


public class AlternatifUpdateActivity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onBackPressed:()V:GetOnBackPressedHandler\n" +
			"";
		mono.android.Runtime.register ("AplikasiMoora.Activities.AlternatifUpdateActivity, AplikasiMoora", AlternatifUpdateActivity.class, __md_methods);
	}


	public AlternatifUpdateActivity ()
	{
		super ();
		if (getClass () == AlternatifUpdateActivity.class)
			mono.android.TypeManager.Activate ("AplikasiMoora.Activities.AlternatifUpdateActivity, AplikasiMoora", "", this, new java.lang.Object[] {  });
	}


	public AlternatifUpdateActivity (int p0)
	{
		super (p0);
		if (getClass () == AlternatifUpdateActivity.class)
			mono.android.TypeManager.Activate ("AplikasiMoora.Activities.AlternatifUpdateActivity, AplikasiMoora", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onBackPressed ()
	{
		n_onBackPressed ();
	}

	private native void n_onBackPressed ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
