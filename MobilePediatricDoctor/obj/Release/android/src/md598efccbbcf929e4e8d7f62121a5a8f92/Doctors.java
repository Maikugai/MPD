package md598efccbbcf929e4e8d7f62121a5a8f92;


public class Doctors
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("TheWae.Models.Doctors, MobilePediatricDoctor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Doctors.class, __md_methods);
	}


	public Doctors ()
	{
		super ();
		if (getClass () == Doctors.class)
			mono.android.TypeManager.Activate ("TheWae.Models.Doctors, MobilePediatricDoctor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
