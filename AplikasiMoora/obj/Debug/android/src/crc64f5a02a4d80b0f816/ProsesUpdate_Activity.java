package crc64f5a02a4d80b0f816;


public class ProsesUpdate_Activity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AplikasiMoora.Activities.ProsesUpdate_Activity, AplikasiMoora", ProsesUpdate_Activity.class, __md_methods);
	}


	public ProsesUpdate_Activity ()
	{
		super ();
		if (getClass () == ProsesUpdate_Activity.class)
			mono.android.TypeManager.Activate ("AplikasiMoora.Activities.ProsesUpdate_Activity, AplikasiMoora", "", this, new java.lang.Object[] {  });
	}


	public ProsesUpdate_Activity (int p0)
	{
		super (p0);
		if (getClass () == ProsesUpdate_Activity.class)
			mono.android.TypeManager.Activate ("AplikasiMoora.Activities.ProsesUpdate_Activity, AplikasiMoora", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
