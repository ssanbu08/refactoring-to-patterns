﻿using RefactoringToPatterns.State.Common;
using RefactoringToPatterns.State.Common.Enum;
using RefactoringToPatterns.State.Common.Exceptions.Permission;

namespace RefactoringToPatterns.State.Step4.State
{
    public class WishListItemRequestedToDirector : WishListItemState
    {
        public override WishListItemStatus Status => WishListItemStatus.RequestedToDirector;

        public void AcceptBy(User user, WishListItem item)
        {
            if (!user.IsDirectorOf(item.Owner))
            {
                throw new UserDoesNotHavePermissionToAcceptRequestedWishListItemException();
            }

            item.State = Accepted;
        }

        public void RejectBy(User user, WishListItem item)
        {
            if (!user.IsDirectorOf(item.Owner))
            {
                throw new UserDoesNotHavePermissionToRejectRequestedWishListItemException();
            }

            item.State = Rejected;
        }
    }
}