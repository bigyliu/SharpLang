// CS7083: Expression must be implicitly convertible to Boolean or its type `C' must define operator `true'
// Line: 8

class C
{
	dynamic M (dynamic d)
	{
		return this || d;
	}
}