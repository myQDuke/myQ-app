package xamarinstore;


public class SlidingLayout
	extends android.widget.LinearLayout
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getChildDrawingOrder:(II)I:GetGetChildDrawingOrder_IIHandler\n" +
			"n_getTranslationY:()F:GetGetTranslationYHandler\n" +
			"n_setTranslationY:(F)V:GetSetTranslationY_FHandler\n" +
			"n_getAlpha:()F:GetGetAlphaHandler\n" +
			"n_setAlpha:(F)V:GetSetAlpha_FHandler\n" +
			"n_getTranslationX:()F:GetGetTranslationXHandler\n" +
			"n_setTranslationX:(F)V:GetSetTranslationX_FHandler\n" +
			"";
		mono.android.Runtime.register ("XamarinStore.SlidingLayout, XamarinStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SlidingLayout.class, __md_methods);
	}


	public SlidingLayout (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == SlidingLayout.class)
			mono.android.TypeManager.Activate ("XamarinStore.SlidingLayout, XamarinStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public SlidingLayout (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == SlidingLayout.class)
			mono.android.TypeManager.Activate ("XamarinStore.SlidingLayout, XamarinStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public SlidingLayout (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == SlidingLayout.class)
			mono.android.TypeManager.Activate ("XamarinStore.SlidingLayout, XamarinStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public int getChildDrawingOrder (int p0, int p1)
	{
		return n_getChildDrawingOrder (p0, p1);
	}

	private native int n_getChildDrawingOrder (int p0, int p1);


	public float getTranslationY ()
	{
		return n_getTranslationY ();
	}

	private native float n_getTranslationY ();


	public void setTranslationY (float p0)
	{
		n_setTranslationY (p0);
	}

	private native void n_setTranslationY (float p0);


	public float getAlpha ()
	{
		return n_getAlpha ();
	}

	private native float n_getAlpha ();


	public void setAlpha (float p0)
	{
		n_setAlpha (p0);
	}

	private native void n_setAlpha (float p0);


	public float getTranslationX ()
	{
		return n_getTranslationX ();
	}

	private native float n_getTranslationX ();


	public void setTranslationX (float p0)
	{
		n_setTranslationX (p0);
	}

	private native void n_setTranslationX (float p0);

	java.util.ArrayList refList;
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
