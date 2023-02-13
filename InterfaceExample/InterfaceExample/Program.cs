

using InterfaceExample;

IFlyable plane = new Plane();

plane.Name = "Emirates E11";
plane.PlaneInfo();

/*
ITransport bus = new Bus();
bus.Name = "Green Line";
*/

ITransport t = (ITransport) plane;
t.StartEngine();
t.StopEngine();
t.Move();

ITransport bus = new Bus();

