# ps-authorization-authentication-dotnetcore
Course work from Pluralsight's Authentication &amp; Authorization in ASP.NET Core By Robert Guijt
General Overview of Content Covered:
> Authentication
> Utilization  of Centralized Authentication
> Applying Authorization

Granual Scope into the Course
>> claims-based authentication &amp; authorization
>> identity cookie
>> ClaimsPrincipal
>> external identity providers

Different between Claims-based Authentication &amp; Authorization
>> Authentication: go to hotel with reservation, ask for id, because they need to make sure you are who you see.
>> determine identity but need proof. the hotel needs a passport, the application needs a password.
>> Authorization: after the hotel confirms who are you, handed hotel key but not before certain claims are checked
>> on the passport. Key provided by hotel only allows entrance to your room and pool (hypothetically) but not doors
>> of other rooms.
>> This above form of limited access via hotel key is analogous to the limited access (Authorization) provides
>> Authorization determines: what actions a user can take and limits access accordingly.
>> NOTE: Authorization requires Authentication FIRST


