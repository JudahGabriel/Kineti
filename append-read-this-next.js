const addPopularPostLink = function() {
   // Appending a "read this next" to each post footer.
   const popularAndRecentPosts = document.querySelectorAll(".popular-posts li a");
   if (popularAndRecentPosts.length > 0) {
      const postFooters = Array.from(document.querySelectorAll(".post-footer"));
      postFooters.forEach((index, footer) => {
         const randomPost = popularAndRecentPosts[Math.floor(Math.random()*popularAndRecentPosts.length)];
         const youMightAlsoLike = document.createElement("div"); 
         youMightAlsoLike.innerHTML = '<div class="you-might-like">Read this next: <a href="' + randomPost.href + '">' + randomPost.innerText + '</div>';
         footer.prepend(youMightAlsoLike);
      });
   }
}
setTimeout(addPopularPostLink, 1000);
