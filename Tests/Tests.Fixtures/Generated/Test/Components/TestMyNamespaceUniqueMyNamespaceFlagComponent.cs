//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    static readonly My.Namespace.UniqueMyNamespaceFlagComponent myNamespaceUniqueMyNamespaceFlagComponent = new My.Namespace.UniqueMyNamespaceFlagComponent();

    public bool isMyNamespaceUniqueMyNamespaceFlag {
        get { return HasComponent(TestComponentsLookup.MyNamespaceUniqueMyNamespaceFlag); }
        set {
            if(value != isMyNamespaceUniqueMyNamespaceFlag) {
                if(value) {
                    AddComponent(TestComponentsLookup.MyNamespaceUniqueMyNamespaceFlag, myNamespaceUniqueMyNamespaceFlagComponent);
                } else {
                    RemoveComponent(TestComponentsLookup.MyNamespaceUniqueMyNamespaceFlag);
                }
            }
        }
    }
}