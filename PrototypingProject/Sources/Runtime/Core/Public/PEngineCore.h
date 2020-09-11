class PEngineCore
{
protected:
	PEngineCore();
public:
	static PEngineCore* GetInstance();
	static void Initialize();
	static bool UpdateApplication();
	static void Release();
};