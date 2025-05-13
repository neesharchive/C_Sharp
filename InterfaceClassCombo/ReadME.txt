// -- interface/class combo, multi-level
// 1. SmartDevice inherits DeviceBase and implements INetworked + IRechargeable.
// 2. Interface IReadable inherits IPrintable → class implements both.
// 3. Parent class and interface both define same method → call using base, derived, interface refs.
