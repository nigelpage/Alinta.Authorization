# Alinta.Authorization

Policy driven authorization framework to support zero trust applications

Provides support for mapping sets of permission to roles and mapping users to them. Permissions are tied to applications, but roles are not. Roles are hierarchical, providing the capability to have a role based on another.

The policy engine supports pluggable check targets, such as source IP address checker, behaviour checker, etc...
