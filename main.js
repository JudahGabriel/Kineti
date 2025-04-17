class Main {
  addPopularPostLink() {
    // Appending a "read this next" to each post footer.
    const popularAndRecentPosts = document.querySelectorAll(".popular-posts li a");
    if (popularAndRecentPosts.length > 0) {
       const postFooters = Array.from(document.querySelectorAll(".post-footer"));
       postFooters.forEach(footer => {
          const randomPost = popularAndRecentPosts[Math.floor(Math.random()*popularAndRecentPosts.length)];
          const youMightAlsoLike = document.createElement("div"); 
          youMightAlsoLike.innerHTML = '<div class="you-might-like">Read this next: <a href="' + randomPost.href + '">' + randomPost.innerText + '</div>';
          footer.prepend(youMightAlsoLike);
       });
    }
  }

  hideDisqusAds() {
    const topAds = document.querySelector("#disqus_recommendations");
    topAds?.remove();

    const disqusFrames = Array.from(document.querySelectorAll("#disqus_thread iframe"));
    disqusFrames.filter(f => f.src && !f.src.startsWith("https://disqus.com/embed/comments")).forEach(f => f.remove());
  }
}

const main = new Main();

// Append a "read this next" to each post footer.
setTimeout(() => {
  main.addPopularPostLink();
  main.hideDisqusAds();
}, 1000);
