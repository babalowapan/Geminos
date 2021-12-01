mergeInto(LibraryManager.library, {
    SendData: function (x, game) {
      var str = Pointer_stringify(game);
      SD(x, str);
    }
});