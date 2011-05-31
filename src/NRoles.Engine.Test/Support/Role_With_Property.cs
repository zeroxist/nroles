﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NRoles.Engine.Test.Support {

  [RoleTest(CompositionType = typeof(Role_With_Property_Composition_With_Property_Superceded))]
  [RoleTest(CompositionType = typeof(Derived_Class_From_Base_Class_With_Property))]
  public interface Role_With_Property : Role {
    int Property { get; }
  }

  public class Role_With_Property_Composition_With_Property_Superceded : Does<Role_With_Property> {
    public int Property { get; set; }
  }
  
  public class Base_Class_With_Property {
    public int Property { get { return 42; } }
  }
  public class Derived_Class_From_Base_Class_With_Property : Base_Class_With_Property, Does<Role_With_Property> { }

}
