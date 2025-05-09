## Features

- Define two user types: Admin and NormalUser.  
- Assign roles automatically based on user type.  
- Admins can temporarily change and restore their roles.  
- Use LINQ to filter and display users by role.  

## Classes

- User (base class)  
- NormalUser : User  
- Admin : User, IRoleChanger  

## Methods

- Roles GetRole() - Returns the user's current role.  
- void ChangeRoleTemporarily() - Admin-specific method to switch to UserRole temporarily.  
- void RestoreOriginalRole() - Admin-specific method to revert to AdminRole.  

## Notes

- Role property is public and defaults to UserRole in User class.  
- Admin constructor explicitly sets the Role to AdminRole.  
- Object initializer is used for assigning ID and Name.  
- LINQ is used to filter out admins and list users accordingly.  
- No protected or private access modifiers are used for the Role property.
