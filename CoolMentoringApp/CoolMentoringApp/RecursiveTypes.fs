namespace Mentoring

module RecursiveTypes =

    type Monkey = {
        Name : string
        Cousin : Chicken
        Cousin2 : Turkey
    }

    and Chicken = {
        Name : string
        Size : float
        Cousin : Monkey
        Cousin2 : Turkey
    }

    and Turkey = {
        Size : float
        Cousin1 : Monkey
        Cousin2 : Chicken
    }



