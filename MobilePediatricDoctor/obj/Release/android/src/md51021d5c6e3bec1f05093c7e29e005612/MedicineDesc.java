package md51021d5c6e3bec1f05093c7e29e005612;


public class MedicineDesc
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MobilePediatricDoctor.Models.MedicineDesc, MobilePediatricDoctor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MedicineDesc.class, __md_methods);
	}


	public MedicineDesc ()
	{
		super ();
		if (getClass () == MedicineDesc.class)
			mono.android.TypeManager.Activate ("MobilePediatricDoctor.Models.MedicineDesc, MobilePediatricDoctor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
