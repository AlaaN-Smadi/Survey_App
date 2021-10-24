package crc64a7a6b04b89628087;


public class softwares_page
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
		mono.android.Runtime.register ("App1.softwares_page, App1", softwares_page.class, __md_methods);
	}


	public softwares_page ()
	{
		super ();
		if (getClass () == softwares_page.class)
			mono.android.TypeManager.Activate ("App1.softwares_page, App1", "", this, new java.lang.Object[] {  });
	}


	public softwares_page (int p0)
	{
		super (p0);
		if (getClass () == softwares_page.class)
			mono.android.TypeManager.Activate ("App1.softwares_page, App1", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
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
