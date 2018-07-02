using System;

namespace Wander.Functional {
 public static class Binding {
  /// Get a reference to a function that takes 0 argument(s), filling out 0.
  public static Action BindAction(Action
   function) {
   return () => function();
  }

  /// Get a reference to a function that takes 1 argument(s), filling out 0.
  public static Action <A> BindAction <A> (Action <A> function) {
   return (A a) => function(a);
  }

  /// Get a reference to a function that takes 1 argument(s), filling out 1.
  public static Action BindAction <A> (Action <A> function, A a) {
   return () => function(a);
  }

  /// Get a reference to a function that takes 2 argument(s), filling out 0.
  public static Action <A, B> BindAction <A, B> (Action <A, B> function) {
   return (A a, B b) => function(a, b);
  }

  /// Get a reference to a function that takes 2 argument(s), filling out 1.
  public static Action <B> BindAction <A, B> (Action <A, B> function, A a) {
   return (B b) => function(a, b);
  }

  /// Get a reference to a function that takes 2 argument(s), filling out 2.
  public static Action BindAction <A, B> (Action <A, B> function, A a, B b) {
   return () => function(a, b);
  }

  /// Get a reference to a function that takes 3 argument(s), filling out 0.
  public static Action <A, B, C> BindAction <A, B, C> (Action <A, B, C> function) {
   return (A a, B b, C c) => function(a, b, c);
  }

  /// Get a reference to a function that takes 3 argument(s), filling out 1.
  public static Action <B, C> BindAction <A, B, C> (Action <A, B, C> function, A a) {
   return (B b, C c) => function(a, b, c);
  }

  /// Get a reference to a function that takes 3 argument(s), filling out 2.
  public static Action <C> BindAction <A, B, C> (Action <A, B, C> function, A a, B b) {
   return (C c) => function(a, b, c);
  }

  /// Get a reference to a function that takes 3 argument(s), filling out 3.
  public static Action BindAction <A, B, C> (Action <A, B, C> function, A a, B b, C c) {
   return () => function(a, b, c);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 0.
  public static Action <A, B, C, D> BindAction <A, B, C, D> (Action <A, B, C, D> function) {
   return (A a, B b, C c, D d) => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 1.
  public static Action <B, C, D> BindAction <A, B, C, D> (Action <A, B, C, D> function, A a) {
   return (B b, C c, D d) => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 2.
  public static Action <C, D> BindAction <A, B, C, D> (Action <A, B, C, D> function, A a, B b) {
   return (C c, D d) => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 3.
  public static Action <D> BindAction <A, B, C, D> (Action <A, B, C, D> function, A a, B b, C c) {
   return (D d) => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 4.
  public static Action BindAction <A, B, C, D> (Action <A, B, C, D> function, A a, B b, C c, D d) {
   return () => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 0.
  public static Action <A, B, C, D, E> BindAction <A, B, C, D, E> (Action <A, B, C, D, E> function) {
   return (A a, B b, C c, D d, E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 1.
  public static Action <B, C, D, E> BindAction <A, B, C, D, E> (Action <A, B, C, D, E> function, A a) {
   return (B b, C c, D d, E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 2.
  public static Action <C, D, E> BindAction <A, B, C, D, E> (Action <A, B, C, D, E> function, A a, B b) {
   return (C c, D d, E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 3.
  public static Action <D, E> BindAction <A, B, C, D, E> (Action <A, B, C, D, E> function, A a, B b, C c) {
   return (D d, E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 4.
  public static Action <E> BindAction <A, B, C, D, E> (Action <A, B, C, D, E> function, A a, B b, C c, D d) {
   return (E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 5.
  public static Action BindAction <A, B, C, D, E> (Action <A, B, C, D, E> function, A a, B b, C c, D d, E e) {
   return () => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F> BindAction <A, B, C, D, E, F> (Action <A, B, C, D, E, F> function) {
   return (A a, B b, C c, D d, E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 1.
  public static Action <B, C, D, E, F> BindAction <A, B, C, D, E, F> (Action <A, B, C, D, E, F> function, A a) {
   return (B b, C c, D d, E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 2.
  public static Action <C, D, E, F> BindAction <A, B, C, D, E, F> (Action <A, B, C, D, E, F> function, A a, B b) {
   return (C c, D d, E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 3.
  public static Action <D, E, F> BindAction <A, B, C, D, E, F> (Action <A, B, C, D, E, F> function, A a, B b, C c) {
   return (D d, E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 4.
  public static Action <E, F> BindAction <A, B, C, D, E, F> (Action <A, B, C, D, E, F> function, A a, B b, C c, D d) {
   return (E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 5.
  public static Action <F> BindAction <A, B, C, D, E, F> (Action <A, B, C, D, E, F> function, A a, B b, C c, D d, E e) {
   return (F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 6.
  public static Action BindAction <A, B, C, D, E, F> (Action <A, B, C, D, E, F> function, A a, B b, C c, D d, E e, F f) {
   return () => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G> BindAction <A, B, C, D, E, F, G> (Action <A, B, C, D, E, F, G> function) {
   return (A a, B b, C c, D d, E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G> BindAction <A, B, C, D, E, F, G> (Action <A, B, C, D, E, F, G> function, A a) {
   return (B b, C c, D d, E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 2.
  public static Action <C, D, E, F, G> BindAction <A, B, C, D, E, F, G> (Action <A, B, C, D, E, F, G> function, A a, B b) {
   return (C c, D d, E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 3.
  public static Action <D, E, F, G> BindAction <A, B, C, D, E, F, G> (Action <A, B, C, D, E, F, G> function, A a, B b, C c) {
   return (D d, E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 4.
  public static Action <E, F, G> BindAction <A, B, C, D, E, F, G> (Action <A, B, C, D, E, F, G> function, A a, B b, C c, D d) {
   return (E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 5.
  public static Action <F, G> BindAction <A, B, C, D, E, F, G> (Action <A, B, C, D, E, F, G> function, A a, B b, C c, D d, E e) {
   return (F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 6.
  public static Action <G> BindAction <A, B, C, D, E, F, G> (Action <A, B, C, D, E, F, G> function, A a, B b, C c, D d, E e, F f) {
   return (G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 7.
  public static Action BindAction <A, B, C, D, E, F, G> (Action <A, B, C, D, E, F, G> function, A a, B b, C c, D d, E e, F f, G g) {
   return () => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G, H> BindAction <A, B, C, D, E, F, G, H> (Action <A, B, C, D, E, F, G, H> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G, H> BindAction <A, B, C, D, E, F, G, H> (Action <A, B, C, D, E, F, G, H> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 2.
  public static Action <C, D, E, F, G, H> BindAction <A, B, C, D, E, F, G, H> (Action <A, B, C, D, E, F, G, H> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 3.
  public static Action <D, E, F, G, H> BindAction <A, B, C, D, E, F, G, H> (Action <A, B, C, D, E, F, G, H> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 4.
  public static Action <E, F, G, H> BindAction <A, B, C, D, E, F, G, H> (Action <A, B, C, D, E, F, G, H> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 5.
  public static Action <F, G, H> BindAction <A, B, C, D, E, F, G, H> (Action <A, B, C, D, E, F, G, H> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 6.
  public static Action <G, H> BindAction <A, B, C, D, E, F, G, H> (Action <A, B, C, D, E, F, G, H> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 7.
  public static Action <H> BindAction <A, B, C, D, E, F, G, H> (Action <A, B, C, D, E, F, G, H> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 8.
  public static Action BindAction <A, B, C, D, E, F, G, H> (Action <A, B, C, D, E, F, G, H> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return () => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G, H, I> BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G, H, I> BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 2.
  public static Action <C, D, E, F, G, H, I> BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 3.
  public static Action <D, E, F, G, H, I> BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 4.
  public static Action <E, F, G, H, I> BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 5.
  public static Action <F, G, H, I> BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 6.
  public static Action <G, H, I> BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 7.
  public static Action <H, I> BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 8.
  public static Action <I> BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 9.
  public static Action BindAction <A, B, C, D, E, F, G, H, I> (Action <A, B, C, D, E, F, G, H, I> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return () => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G, H, I, J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G, H, I, J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 2.
  public static Action <C, D, E, F, G, H, I, J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 3.
  public static Action <D, E, F, G, H, I, J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 4.
  public static Action <E, F, G, H, I, J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 5.
  public static Action <F, G, H, I, J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 6.
  public static Action <G, H, I, J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 7.
  public static Action <H, I, J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 8.
  public static Action <I, J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 9.
  public static Action <J> BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 10.
  public static Action BindAction <A, B, C, D, E, F, G, H, I, J> (Action <A, B, C, D, E, F, G, H, I, J> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return () => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G, H, I, J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G, H, I, J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 2.
  public static Action <C, D, E, F, G, H, I, J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 3.
  public static Action <D, E, F, G, H, I, J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 4.
  public static Action <E, F, G, H, I, J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 5.
  public static Action <F, G, H, I, J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 6.
  public static Action <G, H, I, J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 7.
  public static Action <H, I, J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 8.
  public static Action <I, J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 9.
  public static Action <J, K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 10.
  public static Action <K> BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 11.
  public static Action BindAction <A, B, C, D, E, F, G, H, I, J, K> (Action <A, B, C, D, E, F, G, H, I, J, K> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G, H, I, J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G, H, I, J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 2.
  public static Action <C, D, E, F, G, H, I, J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 3.
  public static Action <D, E, F, G, H, I, J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 4.
  public static Action <E, F, G, H, I, J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 5.
  public static Action <F, G, H, I, J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 6.
  public static Action <G, H, I, J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 7.
  public static Action <H, I, J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 8.
  public static Action <I, J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 9.
  public static Action <J, K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 10.
  public static Action <K, L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 11.
  public static Action <L> BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 12.
  public static Action BindAction <A, B, C, D, E, F, G, H, I, J, K, L> (Action <A, B, C, D, E, F, G, H, I, J, K, L> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G, H, I, J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G, H, I, J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 2.
  public static Action <C, D, E, F, G, H, I, J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 3.
  public static Action <D, E, F, G, H, I, J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 4.
  public static Action <E, F, G, H, I, J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 5.
  public static Action <F, G, H, I, J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 6.
  public static Action <G, H, I, J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 7.
  public static Action <H, I, J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 8.
  public static Action <I, J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 9.
  public static Action <J, K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 10.
  public static Action <K, L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 11.
  public static Action <L, M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 12.
  public static Action <M> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return (M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 13.
  public static Action BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G, H, I, J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 2.
  public static Action <C, D, E, F, G, H, I, J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 3.
  public static Action <D, E, F, G, H, I, J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 4.
  public static Action <E, F, G, H, I, J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 5.
  public static Action <F, G, H, I, J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 6.
  public static Action <G, H, I, J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 7.
  public static Action <H, I, J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 8.
  public static Action <I, J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 9.
  public static Action <J, K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 10.
  public static Action <K, L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 11.
  public static Action <L, M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 12.
  public static Action <M, N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return (M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 13.
  public static Action <N> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) {
   return (N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 14.
  public static Action BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G, H, I, J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 2.
  public static Action <C, D, E, F, G, H, I, J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 3.
  public static Action <D, E, F, G, H, I, J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 4.
  public static Action <E, F, G, H, I, J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 5.
  public static Action <F, G, H, I, J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 6.
  public static Action <G, H, I, J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 7.
  public static Action <H, I, J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 8.
  public static Action <I, J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 9.
  public static Action <J, K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 10.
  public static Action <K, L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 11.
  public static Action <L, M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 12.
  public static Action <M, N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return (M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 13.
  public static Action <N, O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) {
   return (N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 14.
  public static Action <O> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) {
   return (O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 15.
  public static Action BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 0.
  public static Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 1.
  public static Action <B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 2.
  public static Action <C, D, E, F, G, H, I, J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 3.
  public static Action <D, E, F, G, H, I, J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 4.
  public static Action <E, F, G, H, I, J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 5.
  public static Action <F, G, H, I, J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 6.
  public static Action <G, H, I, J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 7.
  public static Action <H, I, J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 8.
  public static Action <I, J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 9.
  public static Action <J, K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 10.
  public static Action <K, L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 11.
  public static Action <L, M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 12.
  public static Action <M, N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return (M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 13.
  public static Action <N, O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) {
   return (N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 14.
  public static Action <O, P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) {
   return (O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 15.
  public static Action <P> BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) {
   return (P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 16.
  public static Action BindAction <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> (Action <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 0 argument(s), filling out 0.
  public static Func <RETURN> BindFunc <RETURN> (Func <RETURN> function) {
   return () => function();
  }

  /// Get a reference to a function that takes 1 argument(s), filling out 0.
  public static Func <A, RETURN> BindFunc <A, RETURN> (Func <A, RETURN> function) {
   return (A a) => function(a);
  }

  /// Get a reference to a function that takes 1 argument(s), filling out 1.
  public static Func <RETURN> BindFunc <A, RETURN> (Func <A, RETURN> function, A a) {
   return () => function(a);
  }

  /// Get a reference to a function that takes 2 argument(s), filling out 0.
  public static Func <A, B, RETURN> BindFunc <A, B, RETURN> (Func <A, B, RETURN> function) {
   return (A a, B b) => function(a, b);
  }

  /// Get a reference to a function that takes 2 argument(s), filling out 1.
  public static Func <B, RETURN> BindFunc <A, B, RETURN> (Func <A, B, RETURN> function, A a) {
   return (B b) => function(a, b);
  }

  /// Get a reference to a function that takes 2 argument(s), filling out 2.
  public static Func <RETURN> BindFunc <A, B, RETURN> (Func <A, B, RETURN> function, A a, B b) {
   return () => function(a, b);
  }

  /// Get a reference to a function that takes 3 argument(s), filling out 0.
  public static Func <A, B, C, RETURN> BindFunc <A, B, C, RETURN> (Func <A, B, C, RETURN> function) {
   return (A a, B b, C c) => function(a, b, c);
  }

  /// Get a reference to a function that takes 3 argument(s), filling out 1.
  public static Func <B, C, RETURN> BindFunc <A, B, C, RETURN> (Func <A, B, C, RETURN> function, A a) {
   return (B b, C c) => function(a, b, c);
  }

  /// Get a reference to a function that takes 3 argument(s), filling out 2.
  public static Func <C, RETURN> BindFunc <A, B, C, RETURN> (Func <A, B, C, RETURN> function, A a, B b) {
   return (C c) => function(a, b, c);
  }

  /// Get a reference to a function that takes 3 argument(s), filling out 3.
  public static Func <RETURN> BindFunc <A, B, C, RETURN> (Func <A, B, C, RETURN> function, A a, B b, C c) {
   return () => function(a, b, c);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 0.
  public static Func <A, B, C, D, RETURN> BindFunc <A, B, C, D, RETURN> (Func <A, B, C, D, RETURN> function) {
   return (A a, B b, C c, D d) => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 1.
  public static Func <B, C, D, RETURN> BindFunc <A, B, C, D, RETURN> (Func <A, B, C, D, RETURN> function, A a) {
   return (B b, C c, D d) => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 2.
  public static Func <C, D, RETURN> BindFunc <A, B, C, D, RETURN> (Func <A, B, C, D, RETURN> function, A a, B b) {
   return (C c, D d) => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 3.
  public static Func <D, RETURN> BindFunc <A, B, C, D, RETURN> (Func <A, B, C, D, RETURN> function, A a, B b, C c) {
   return (D d) => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 4 argument(s), filling out 4.
  public static Func <RETURN> BindFunc <A, B, C, D, RETURN> (Func <A, B, C, D, RETURN> function, A a, B b, C c, D d) {
   return () => function(a, b, c, d);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 0.
  public static Func <A, B, C, D, E, RETURN> BindFunc <A, B, C, D, E, RETURN> (Func <A, B, C, D, E, RETURN> function) {
   return (A a, B b, C c, D d, E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 1.
  public static Func <B, C, D, E, RETURN> BindFunc <A, B, C, D, E, RETURN> (Func <A, B, C, D, E, RETURN> function, A a) {
   return (B b, C c, D d, E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 2.
  public static Func <C, D, E, RETURN> BindFunc <A, B, C, D, E, RETURN> (Func <A, B, C, D, E, RETURN> function, A a, B b) {
   return (C c, D d, E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 3.
  public static Func <D, E, RETURN> BindFunc <A, B, C, D, E, RETURN> (Func <A, B, C, D, E, RETURN> function, A a, B b, C c) {
   return (D d, E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 4.
  public static Func <E, RETURN> BindFunc <A, B, C, D, E, RETURN> (Func <A, B, C, D, E, RETURN> function, A a, B b, C c, D d) {
   return (E e) => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 5 argument(s), filling out 5.
  public static Func <RETURN> BindFunc <A, B, C, D, E, RETURN> (Func <A, B, C, D, E, RETURN> function, A a, B b, C c, D d, E e) {
   return () => function(a, b, c, d, e);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, RETURN> BindFunc <A, B, C, D, E, F, RETURN> (Func <A, B, C, D, E, F, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 1.
  public static Func <B, C, D, E, F, RETURN> BindFunc <A, B, C, D, E, F, RETURN> (Func <A, B, C, D, E, F, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 2.
  public static Func <C, D, E, F, RETURN> BindFunc <A, B, C, D, E, F, RETURN> (Func <A, B, C, D, E, F, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 3.
  public static Func <D, E, F, RETURN> BindFunc <A, B, C, D, E, F, RETURN> (Func <A, B, C, D, E, F, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 4.
  public static Func <E, F, RETURN> BindFunc <A, B, C, D, E, F, RETURN> (Func <A, B, C, D, E, F, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 5.
  public static Func <F, RETURN> BindFunc <A, B, C, D, E, F, RETURN> (Func <A, B, C, D, E, F, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f) => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 6 argument(s), filling out 6.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, RETURN> (Func <A, B, C, D, E, F, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return () => function(a, b, c, d, e, f);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, RETURN> BindFunc <A, B, C, D, E, F, G, RETURN> (Func <A, B, C, D, E, F, G, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, RETURN> BindFunc <A, B, C, D, E, F, G, RETURN> (Func <A, B, C, D, E, F, G, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 2.
  public static Func <C, D, E, F, G, RETURN> BindFunc <A, B, C, D, E, F, G, RETURN> (Func <A, B, C, D, E, F, G, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 3.
  public static Func <D, E, F, G, RETURN> BindFunc <A, B, C, D, E, F, G, RETURN> (Func <A, B, C, D, E, F, G, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 4.
  public static Func <E, F, G, RETURN> BindFunc <A, B, C, D, E, F, G, RETURN> (Func <A, B, C, D, E, F, G, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 5.
  public static Func <F, G, RETURN> BindFunc <A, B, C, D, E, F, G, RETURN> (Func <A, B, C, D, E, F, G, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 6.
  public static Func <G, RETURN> BindFunc <A, B, C, D, E, F, G, RETURN> (Func <A, B, C, D, E, F, G, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g) => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 7 argument(s), filling out 7.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, RETURN> (Func <A, B, C, D, E, F, G, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return () => function(a, b, c, d, e, f, g);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, H, RETURN> BindFunc <A, B, C, D, E, F, G, H, RETURN> (Func <A, B, C, D, E, F, G, H, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, H, RETURN> BindFunc <A, B, C, D, E, F, G, H, RETURN> (Func <A, B, C, D, E, F, G, H, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 2.
  public static Func <C, D, E, F, G, H, RETURN> BindFunc <A, B, C, D, E, F, G, H, RETURN> (Func <A, B, C, D, E, F, G, H, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 3.
  public static Func <D, E, F, G, H, RETURN> BindFunc <A, B, C, D, E, F, G, H, RETURN> (Func <A, B, C, D, E, F, G, H, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 4.
  public static Func <E, F, G, H, RETURN> BindFunc <A, B, C, D, E, F, G, H, RETURN> (Func <A, B, C, D, E, F, G, H, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 5.
  public static Func <F, G, H, RETURN> BindFunc <A, B, C, D, E, F, G, H, RETURN> (Func <A, B, C, D, E, F, G, H, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 6.
  public static Func <G, H, RETURN> BindFunc <A, B, C, D, E, F, G, H, RETURN> (Func <A, B, C, D, E, F, G, H, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 7.
  public static Func <H, RETURN> BindFunc <A, B, C, D, E, F, G, H, RETURN> (Func <A, B, C, D, E, F, G, H, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h) => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 8 argument(s), filling out 8.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, H, RETURN> (Func <A, B, C, D, E, F, G, H, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return () => function(a, b, c, d, e, f, g, h);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, H, I, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, H, I, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 2.
  public static Func <C, D, E, F, G, H, I, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 3.
  public static Func <D, E, F, G, H, I, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 4.
  public static Func <E, F, G, H, I, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 5.
  public static Func <F, G, H, I, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 6.
  public static Func <G, H, I, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 7.
  public static Func <H, I, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 8.
  public static Func <I, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i) => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 9 argument(s), filling out 9.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, H, I, RETURN> (Func <A, B, C, D, E, F, G, H, I, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return () => function(a, b, c, d, e, f, g, h, i);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, H, I, J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, H, I, J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 2.
  public static Func <C, D, E, F, G, H, I, J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 3.
  public static Func <D, E, F, G, H, I, J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 4.
  public static Func <E, F, G, H, I, J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 5.
  public static Func <F, G, H, I, J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 6.
  public static Func <G, H, I, J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 7.
  public static Func <H, I, J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 8.
  public static Func <I, J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 9.
  public static Func <J, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j) => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 10 argument(s), filling out 10.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return () => function(a, b, c, d, e, f, g, h, i, j);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, H, I, J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 2.
  public static Func <C, D, E, F, G, H, I, J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 3.
  public static Func <D, E, F, G, H, I, J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 4.
  public static Func <E, F, G, H, I, J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 5.
  public static Func <F, G, H, I, J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 6.
  public static Func <G, H, I, J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 7.
  public static Func <H, I, J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 8.
  public static Func <I, J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 9.
  public static Func <J, K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 10.
  public static Func <K, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k) => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 11 argument(s), filling out 11.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, H, I, J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 2.
  public static Func <C, D, E, F, G, H, I, J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 3.
  public static Func <D, E, F, G, H, I, J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 4.
  public static Func <E, F, G, H, I, J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 5.
  public static Func <F, G, H, I, J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 6.
  public static Func <G, H, I, J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 7.
  public static Func <H, I, J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 8.
  public static Func <I, J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 9.
  public static Func <J, K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 10.
  public static Func <K, L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 11.
  public static Func <L, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 12 argument(s), filling out 12.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, H, I, J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 2.
  public static Func <C, D, E, F, G, H, I, J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 3.
  public static Func <D, E, F, G, H, I, J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 4.
  public static Func <E, F, G, H, I, J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 5.
  public static Func <F, G, H, I, J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 6.
  public static Func <G, H, I, J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 7.
  public static Func <H, I, J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 8.
  public static Func <I, J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 9.
  public static Func <J, K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 10.
  public static Func <K, L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 11.
  public static Func <L, M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l, M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 12.
  public static Func <M, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return (M m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 13 argument(s), filling out 13.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 2.
  public static Func <C, D, E, F, G, H, I, J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 3.
  public static Func <D, E, F, G, H, I, J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 4.
  public static Func <E, F, G, H, I, J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 5.
  public static Func <F, G, H, I, J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 6.
  public static Func <G, H, I, J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 7.
  public static Func <H, I, J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 8.
  public static Func <I, J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 9.
  public static Func <J, K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 10.
  public static Func <K, L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 11.
  public static Func <L, M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l, M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 12.
  public static Func <M, N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return (M m, N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 13.
  public static Func <N, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) {
   return (N n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 14 argument(s), filling out 14.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 2.
  public static Func <C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 3.
  public static Func <D, E, F, G, H, I, J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 4.
  public static Func <E, F, G, H, I, J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 5.
  public static Func <F, G, H, I, J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 6.
  public static Func <G, H, I, J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 7.
  public static Func <H, I, J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 8.
  public static Func <I, J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 9.
  public static Func <J, K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 10.
  public static Func <K, L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 11.
  public static Func <L, M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l, M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 12.
  public static Func <M, N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return (M m, N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 13.
  public static Func <N, O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) {
   return (N n, O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 14.
  public static Func <O, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) {
   return (O o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 15 argument(s), filling out 15.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 0.
  public static Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function) {
   return (A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 1.
  public static Func <B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a) {
   return (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 2.
  public static Func <C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b) {
   return (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 3.
  public static Func <D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c) {
   return (D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 4.
  public static Func <E, F, G, H, I, J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d) {
   return (E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 5.
  public static Func <F, G, H, I, J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e) {
   return (F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 6.
  public static Func <G, H, I, J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f) {
   return (G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 7.
  public static Func <H, I, J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g) {
   return (H h, I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 8.
  public static Func <I, J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h) {
   return (I i, J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 9.
  public static Func <J, K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i) {
   return (J j, K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 10.
  public static Func <K, L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) {
   return (K k, L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 11.
  public static Func <L, M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k) {
   return (L l, M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 12.
  public static Func <M, N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l) {
   return (M m, N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 13.
  public static Func <N, O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m) {
   return (N n, O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 14.
  public static Func <O, P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n) {
   return (O o, P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 15.
  public static Func <P, RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o) {
   return (P p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }

  /// Get a reference to a function that takes 16 argument(s), filling out 16.
  public static Func <RETURN> BindFunc <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> (Func <A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, RETURN> function, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p) {
   return () => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
  }
 }
}
